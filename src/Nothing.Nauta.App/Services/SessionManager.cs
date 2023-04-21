namespace Nothing.Nauta.App.Services;

using System.Collections.Concurrent;

using Nothing.Nauta.App.Data;
using Nothing.Nauta.App.Data.Extensions;
using Nothing.Nauta.App.Services.Interfaces;
using System.Text.Json;

using Nothing.Nauta.Interfaces;
using System;
using Nothing.Nauta.App.Services.EventArgs;

public class 
    SessionManager : ISessionManager
{
    private const string NautaSessionData = "NautaSessionData";

    private readonly ISecureStorage _secureStorage;

    private readonly ISessionHandler _sessionHandler;

    private TimeSpan? _remainingTime;

    public event EventHandler<SessionManagerStateChangeEventArg>? StateChanged;

    public SessionManager(ISecureStorage secureStorage, ISessionHandler sessionHandler)
    {
        _secureStorage = secureStorage;
        _sessionHandler = sessionHandler;
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

    public ConcurrentDictionary<string, TimeSpan> TimeSpans { get; set; }

    public async Task<(TimeSpan, TimeSpan)> GetTimeAsync()
    {
        var sessionData = await GetSessionDataAsync();
        if (sessionData is null || !sessionData.TryGetValue(SessionDataKeys.Started, out var started) || !DateTime.TryParse(started, out var startDateTime))
        {
            return (TimeSpan.Zero, TimeSpan.Zero);
        }

        this._remainingTime ??= await this._sessionHandler.RemainingTimeAsync(sessionData);

        var remainingTime = _remainingTime.Value;
        return (remainingTime, remainingTime.Subtract(DateTime.Now.Subtract(startDateTime)));
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
        _remainingTime = null;
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