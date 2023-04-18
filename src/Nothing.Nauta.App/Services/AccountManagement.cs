using Nothing.Nauta.App.Services.Interfaces;

namespace Nothing.Nauta.App.Services
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.VisualBasic;

    using Nothing.Nauta.App.Data;
    using Nothing.Nauta.App.Data.Extensions;

    public class AccountManagement : IAccountManagement
    {
        private readonly AppDbContext appDbContext;

        private readonly ISecureStorage secureStorage;

        public AccountManagement(AppDbContext appDbContext, ISecureStorage secureStorage)
        {
            this.appDbContext = appDbContext;
            this.secureStorage = secureStorage;
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
            return await this.appDbContext.Accounts.ToListAsync();
        }

        //public Task OpenAsync(AccountViewModel context)
        //{
        //    //foreach (var accountInfo in this.dbContext.Accounts)
        //    //{

        //    //}
        //}
    }
}
