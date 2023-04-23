// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SessionManager.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Services;

using System;
using System.Globalization;
using System.Text.Json;
using Nothing.Nauta.App.Data;
using Nothing.Nauta.App.Data.Extensions;
using Nothing.Nauta.App.Services.EventArgs;
using Nothing.Nauta.App.Services.Interfaces;
using Nothing.Nauta.Interfaces;

public class SessionManager : ISessionManager
{
    public const string NautaSessionData = "NautaSessionData";

    public const string StartedTimeFormat = "MM/dd/yyyy HH:mm:ss";

    private readonly ISecureStorage secureStorage;

    private readonly ISessionHandler sessionHandler;

    private readonly ITimeService timeService;

    public SessionManager(ISecureStorage secureStorage, ISessionHandler sessionHandler, ITimeService timeService)
    {
        this.secureStorage = secureStorage;
        this.sessionHandler = sessionHandler;
        this.timeService = timeService;
    }

    public event EventHandler<SessionManagerStateChangeEventArg>? StateChanged;

    public async Task<Dictionary<string, string>?> GetSessionDataAsync()
    {
        Dictionary<string, string>? sessionData = null;
        try
        {
            var serializedSessionData = await this.secureStorage.GetAsync(NautaSessionData);
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
        var sessionData = await this.GetSessionDataAsync();
        if (sessionData is null || !sessionData.TryGetValue(SessionDataKeys.Started, out var started) || !DateTime.TryParseExact(started, StartedTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out var startDateTime))
        {
            return (TimeSpan.Zero, TimeSpan.Zero);
        }

        var remainingTime = await this.sessionHandler.RemainingTimeAsync(sessionData);
        return (Total: remainingTime, RemainingTime: remainingTime.Subtract(this.timeService.Now().Subtract(startDateTime)));
    }

    public async Task OpenAsync(string userName, string? password)
    {
        var sessionData = await this.sessionHandler.OpenAsync(userName, password);
        if (sessionData is not null)
        {
            await this.secureStorage.SetAsync(NautaSessionData, JsonSerializer.Serialize(sessionData));
            this.OnStateChanged(new SessionManagerStateChangeEventArg(true));
        }
    }

    public async Task CloseAsync()
    {
        var sessionData = await this.GetSessionDataAsync();
        if (sessionData is not null)
        {
            await this.sessionHandler.CloseAsync(sessionData);
            this.secureStorage.Remove(NautaSessionData);
            this.OnStateChanged(new SessionManagerStateChangeEventArg(false));
        }
    }

    public Task ForceCloseAsync()
    {
        this.secureStorage.Remove(NautaSessionData);
        this.OnStateChanged(new SessionManagerStateChangeEventArg(false));

        return Task.CompletedTask;
    }

    public async Task<bool> IsConnectedAsync(AccountInfo accountInfo)
    {
        var sessionData = await this.GetSessionDataAsync();
        if (sessionData?.TryGetValue(SessionDataKeys.UserName, out var currentSessionUserName) ?? false)
        {
            return accountInfo.GetUserName() == currentSessionUserName;
        }

        return false;
    }

    public async Task<bool> IsConnectedAsync()
    {
        var sessionData = await this.GetSessionDataAsync();
        if (sessionData?.TryGetValue(SessionDataKeys.UserName, out var currentSessionUserName) ?? false)
        {
            return true;
        }

        return false;
    }

    protected virtual void OnStateChanged(SessionManagerStateChangeEventArg e)
    {
        this.StateChanged?.Invoke(this, e);
    }
}