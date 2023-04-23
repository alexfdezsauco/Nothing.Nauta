namespace Nothing.Nauta.App.Services;

using System.Collections.Concurrent;

using Nothing.Nauta.App.Data;
using Nothing.Nauta.App.Data.Extensions;
using Nothing.Nauta.App.Services.Interfaces;
using System.Text.Json;

using Nothing.Nauta.Interfaces;
using System;
using System.Globalization;

using Microsoft.EntityFrameworkCore.Design;

using Nothing.Nauta.App.Services.EventArgs;

public class SessionManager : ISessionManager
{
    public const string NautaSessionData = "NautaSessionData";

    public const string StartedTimeFormat = "MM/dd/yyyy HH:mm:ss";


    private readonly ISecureStorage _secureStorage;

    private readonly ISessionHandler _sessionHandler;

    private readonly ITimeService _timeService;

    public event EventHandler<SessionManagerStateChangeEventArg>? StateChanged;

    public SessionManager(ISecureStorage secureStorage, ISessionHandler sessionHandler, ITimeService timeService)
    {
        _secureStorage = secureStorage;
        _sessionHandler = sessionHandler;
        _timeService = timeService;
    }

    public async Task<Dictionary<string, string>?> GetSessionDataAsync()
    {
        Dictionary<string, string>? sessionData = null;
        try
        {
            var serializedSessionData = await _secureStorage.GetAsync(NautaSessionData);
            sessionData = JsonSerializer.Deserialize<Dictionary<string, string>>(serializedSessionData);
        }
        catch (Exception)
        {
            // Ignore
        }

        return sessionData;
    }

    public async Task<(TimeSpan Total, TimeSpan RemainingTime)> GetTimeAsync()
    {
        var sessionData = await GetSessionDataAsync();
        if (sessionData is null || !sessionData.TryGetValue(SessionDataKeys.Started, out var started) || !DateTime.TryParseExact(started, StartedTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out var startDateTime))
        {
            return (TimeSpan.Zero, TimeSpan.Zero);
        }

        var remainingTime = await this._sessionHandler.RemainingTimeAsync(sessionData);
        return (Total: remainingTime, RemainingTime: remainingTime.Subtract(this._timeService.Now().Subtract(startDateTime)));
    }

    public async Task OpenAsync(string userName, string? password)
    {
        var sessionData = await _sessionHandler.OpenAsync(userName, password);
        if (sessionData is not null)
        {
            await _secureStorage.SetAsync(NautaSessionData, JsonSerializer.Serialize(sessionData));
            OnStateChanged(new SessionManagerStateChangeEventArg(true));
        }
    }

    public async Task CloseAsync()
    {
        var sessionData = await GetSessionDataAsync();
        await _sessionHandler.CloseAsync(sessionData);
        _secureStorage.Remove(NautaSessionData);
        OnStateChanged(new SessionManagerStateChangeEventArg(false));
    }

    public Task ForceCloseAsync()
    {
        _secureStorage.Remove(NautaSessionData);
        OnStateChanged(new SessionManagerStateChangeEventArg(false));
        
        return Task.CompletedTask;
    }

    public async Task<bool> IsConnectedAsync()
    {
        var sessionData = await GetSessionDataAsync();
        if (sessionData?.TryGetValue(SessionDataKeys.UserName, out var currentSessionUserName) ?? false)
        {
            return true;
        }

        return false;
    }

    public async Task<bool> IsConnectedAsync(AccountInfo accountInfo)
    {
        var sessionData = await GetSessionDataAsync();
        if (sessionData?.TryGetValue(SessionDataKeys.UserName, out var currentSessionUserName) ?? false)
        {
            return accountInfo.GetUserName() == currentSessionUserName;
        }

        return false;
    }

    protected virtual void OnStateChanged(SessionManagerStateChangeEventArg e)
    {
        StateChanged?.Invoke(this, e);
    }
}