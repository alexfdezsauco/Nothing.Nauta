// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISessionManager.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Services.Interfaces;

using Nothing.Nauta.App.Data;
using Nothing.Nauta.App.Services.EventArgs;

public interface ISessionManager
{
    event EventHandler<SessionManagerStateChangeEventArg> StateChanged;

    Task<bool> IsConnectedAsync(AccountInfo accountInfo);

    Task<bool> IsConnectedAsync();

    Task<Dictionary<string, string>?> GetSessionDataAsync();

    Task<(TimeSpan Total, TimeSpan RemainingTime)> GetTimeAsync();

    Task OpenAsync(string userName, string? password);

    Task CloseAsync();

    Task ForceCloseAsync();
}