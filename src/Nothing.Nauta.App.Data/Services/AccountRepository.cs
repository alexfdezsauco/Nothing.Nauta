// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountRepository.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Data.Services;

using Microsoft.EntityFrameworkCore;

using Nothing.Nauta.App.Data;
using Nothing.Nauta.App.Data.Services.Interfaces;

/// <summary>
/// The account repository class.
/// </summary>
public class AccountRepository : IAccountRepository
{
    private readonly AppDbContext appDbContext;

    /// <summary>
    /// Initializes a new instance of the <see cref="AccountRepository"/> class.
    /// </summary>
    /// <param name="appDbContext">
    /// The data context.
    /// </param>
    public AccountRepository(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
    }

    /// <inheritdoc/>
    public async Task AddAsync(AccountInfo accountInfo)
    {
        await this.appDbContext.AddAsync(accountInfo);
        await this.appDbContext.SaveChangesAsync();
    }

    /// <inheritdoc/>
    public async Task UpdateAsync(AccountInfo accountInfo)
    {
        var storedAccountInfo = this.appDbContext.Accounts?.FirstOrDefault(info => info.Id == accountInfo.Id);
        if (storedAccountInfo is not null)
        {
            this.appDbContext.Entry(storedAccountInfo).State = EntityState.Detached;
        }

        this.appDbContext.Entry(accountInfo).State = EntityState.Modified;
        await this.appDbContext.SaveChangesAsync();
    }

    /// <inheritdoc/>
    public async Task RemoveAsync(AccountInfo accountInfo)
    {
        this.appDbContext.Remove(accountInfo);
        await this.appDbContext.SaveChangesAsync();
    }

    /// <inheritdoc/>
    public async Task<List<AccountInfo>> ListAsync()
    {
        return await this.appDbContext.Accounts!.ToListAsync().ConfigureAwait(false);
    }
}