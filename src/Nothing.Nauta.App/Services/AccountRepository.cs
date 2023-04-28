// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountRepository.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Services;

using Microsoft.EntityFrameworkCore;

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Added:
using Nothing.Nauta.App.Data;
*/
using Nothing.Nauta.App.Data;

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Removed:
using Nothing.Nauta.App.Data;
*/
using Nothing.Nauta.App.Services.Interfaces;

public class AccountRepository : IAccountRepository
{
    private readonly AppDbContext appDbContext;

    public AccountRepository(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
    }

    public async Task AddAsync(AccountInfo accountInfo)
    {
        await this.appDbContext.AddAsync(accountInfo);
        await this.appDbContext.SaveChangesAsync();
    }

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

    public async Task RemoveAsync(AccountInfo accountInfo)
    {
        this.appDbContext.Remove(accountInfo);
        await this.appDbContext.SaveChangesAsync();
    }

    public async Task<List<AccountInfo>> ListAsync()
    {
        return await this.appDbContext.Accounts!.ToListAsync().ConfigureAwait(false);
    }
}