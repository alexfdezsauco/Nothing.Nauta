// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SessionManagerStateChangeEventArg.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Services.EventArgs;

public class SessionManagerStateChangeEventArg
{
    public SessionManagerStateChangeEventArg(bool isConnected)
    {
        this.IsConnected = isConnected;
    }

    public bool IsConnected { get; }
}