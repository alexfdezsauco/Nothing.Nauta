namespace Nothing.Nauta.App.Services.Interfaces;

using Nothing.Nauta.App.Data;

public interface IAccountManagement
{
    Task AddAsync(AccountInfo accountInfo);

    Task<List<AccountInfo>> ListAsync();

    Task UpdateAsync(AccountInfo accountInfo);

    Task RemoveAsync(AccountInfo accountInfo);
}