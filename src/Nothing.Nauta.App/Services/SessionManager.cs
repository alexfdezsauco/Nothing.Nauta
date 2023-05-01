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
using Nothing.Nauta.App.Data.Services.Interfaces;
using Nothing.Nauta.App.Services.EventArgs;
using Nothing.Nauta.App.Services.Interfaces;
using Nothing.Nauta.Interfaces;

/// <summary>
/// The session manager class.
/// </summary>
public sealed class SessionManager : ISessionManager
{
    public const string NautaSessionData = "NautaSessionData";

    public const string StartedTimeFormat = "MM/dd/yyyy HH:mm:ss";

    private readonly ISecureStorage secureStorage;

    private readonly ISessionHandler sessionHandler;

    private readonly ITimeService timeService;

    private readonly IAccountRepository accountRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="SessionManager"/> class.
    /// </summary>
    /// <param name="secureStorage">The secure storage.</param>
    /// <param name="sessionHandler">The session handler.</param>
    /// <param name="timeService">The time service.</param>
    /// <param name="accountRepository">The account repository.</param>
    public SessionManager(ISecureStorage secureStorage, ISessionHandler sessionHandler, ITimeService timeService, IAccountRepository accountRepository)
    {
        this.secureStorage = secureStorage;
        this.sessionHandler = sessionHandler;
        this.timeService = timeService;
        this.accountRepository = accountRepository;
    }

    /// <inheritdoc />
    public event EventHandler<SessionManagerStateChangeEventArg>? StateChanged;

    /// <inheritdoc />
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

    /// <inheritdoc />
    public async Task<(TimeSpan Total, TimeSpan RemainingTime)> GetTimeAsync()
    {
        var sessionData = await this.GetSessionDataAsync();
        if (sessionData is null || !sessionData.TryGetValue(SessionDataKeys.Started, out var started) || !DateTime.TryParseExact(started, StartedTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out var startDateTime))
        {
            return (TimeSpan.Zero, TimeSpan.Zero);
        }

        var (username, accountType) = GetAccountInfoFromSessionData(sessionData);
        if (username == string.Empty || accountType == AccountType.None)
        {
            return (TimeSpan.Zero, TimeSpan.Zero);
        }

        var accountInfo = await this.UpdateRemainingTimeAsync(sessionData);

        var totalTime = accountInfo.RemainingTime;
        var elapsedTime = this.timeService.Now().Subtract(accountInfo.ResetDateTime);
        return (Total: totalTime, RemainingTime: totalTime.Subtract(elapsedTime));
    }

    private static (string Username, AccountType AccountType) GetAccountInfoFromSessionData(Dictionary<string, string> sessionData)
    {
        if (!sessionData.TryGetValue(SessionDataKeys.UserName, out var sessionUsername))
        {
            return (string.Empty, AccountType.None);
        }

        var sessionUsernameParts = sessionUsername.Split('@');
        var accountType = AccountType.International;

        var domain = sessionUsernameParts[1];
        if (domain == "nauta.co.cu")
        {
            accountType = AccountType.National;
        }

        var username = sessionUsernameParts[0];

        return (username, accountType);
    }

    /// <inheritdoc />
    public async Task OpenAsync(string userName, string? password)
    {
        var sessionData = await this.sessionHandler.OpenAsync(userName, password);
        if (sessionData is not null)
        {
            await this.secureStorage.SetAsync(NautaSessionData, JsonSerializer.Serialize(sessionData));
            await this.UpdateRemainingTimeAsync(sessionData, true);
            this.OnStateChanged(new SessionManagerStateChangeEventArg(true));
        }
    }

    /// <inheritdoc />
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

    /// <inheritdoc />
    public Task ForceCloseAsync()
    {
        this.secureStorage.Remove(NautaSessionData);
        this.OnStateChanged(new SessionManagerStateChangeEventArg(false));
        return Task.CompletedTask;
    }

    /// <inheritdoc />
    public async Task<bool> IsOpenAsync(AccountInfo accountInfo)
    {
        var sessionData = await this.GetSessionDataAsync();
        if (sessionData?.TryGetValue(SessionDataKeys.UserName, out var currentSessionUserName) ?? false)
        {
            return accountInfo.GetUserName() == currentSessionUserName;
        }

        return false;
    }

    /// <inheritdoc />
    public async Task<bool> IsConnectedAsync()
    {
        var sessionData = await this.GetSessionDataAsync();
        if (sessionData?.TryGetValue(SessionDataKeys.UserName, out _) ?? false)
        {
            return true;
        }

        return false;
    }

    private void OnStateChanged(SessionManagerStateChangeEventArg e)
    {
        this.StateChanged?.Invoke(this, e);
    }

    private async Task<AccountInfo> UpdateRemainingTimeAsync(Dictionary<string, string> sessionData, bool reset = false)
    {
        var (username, accountType) = GetAccountInfoFromSessionData(sessionData);

        var accountInfo = await this.accountRepository.GetAsync(username, accountType);
        var remainingTime = await this.sessionHandler.RemainingTimeAsync(sessionData);
        if (reset || accountInfo.RemainingTime < remainingTime)
        {
            accountInfo.ResetDateTime = this.timeService.Now();
            accountInfo.RemainingTime = remainingTime;
            await this.accountRepository.UpdateAsync(accountInfo);
        }

        return accountInfo;
    }

}