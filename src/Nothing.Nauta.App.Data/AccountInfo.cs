// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountInfo.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Data;

public class AccountInfo
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public AccountType AccountType { get; set; } = AccountType.International;

    public TimeSpan RemainingTime { get; set; }

    public DateTime ResetDateTime { get; set; }
}