// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAccountRepository.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Services.Interfaces;

using Nothing.Nauta.App.Data;

public interface IAccountRepository
{
    Task AddAsync(AccountInfo accountInfo);

    Task<List<AccountInfo>> ListAsync();

    Task UpdateAsync(AccountInfo accountInfo);

    Task RemoveAsync(AccountInfo accountInfo);
}