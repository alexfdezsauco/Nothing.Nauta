// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAccountRepository.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Data.Services.Interfaces;

using Nothing.Nauta.App.Data;

/// <summary>
/// The account repository interface.
/// </summary>
public interface IAccountRepository
{
    /// <summary>
    /// Adds an <see cref="AccountInfo"/>.
    /// </summary>
    /// <param name="accountInfo">
    /// The account info.
    /// </param>
    /// <returns>
    /// A <see cref="Task"/>.
    /// </returns>
    Task AddAsync(AccountInfo accountInfo);

    /// <summary>
    /// List all <see cref="AccountInfo"/>.
    /// </summary>
    /// <returns>
    /// A <see cref="Task{AccountInfo}"/>.
    /// </returns>
    Task<List<AccountInfo>> ListAsync();

    /// <summary>
    /// Updates an <see cref="AccountInfo"/>.
    /// </summary>
    /// <param name="accountInfo">
    /// The account info.
    /// </param>
    /// <returns>
    /// A <see cref="Task"/>.
    /// </returns>
    Task UpdateAsync(AccountInfo accountInfo);

    /// <summary>
    /// Removes an <see cref="AccountInfo"/>.
    /// </summary>
    /// <param name="accountInfo">
    /// The account info.
    /// </param>
    /// <returns>
    /// A <see cref="Task"/>.
    /// </returns>
    Task RemoveAsync(AccountInfo accountInfo);

    /// <summary>
    /// Gets user by Username and account type.
    /// </summary>
    /// <param name="username">The username.</param>
    /// <param name="accountType">The account type.</param>
    /// <returns>A Task{AccountInfo}.</returns>
    Task<AccountInfo> GetAsync(string username, AccountType accountType);
}