// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountInfoExtensions.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Data.Extensions;

public static class AccountInfoExtensions
{
    public static string GetUserName(this AccountInfo accountInfo)
    {
        return accountInfo.AccountType == AccountType.International
                   ? accountInfo.Username + "@nauta.com.cu"
                   : accountInfo.Username + "@nauta.co.cu";
    }
}