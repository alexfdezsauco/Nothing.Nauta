namespace Nothing.Nauta.App.Services;

using Nothing.Nauta.App.Data;

public class AccountViewModel
{
    public AccountInfo AccountInfo { get; }

    public AccountViewModel(AccountInfo accountInfo, bool isConnected)
    {
        this.AccountInfo = accountInfo;
        this.IsConnected = isConnected;
    }

    public bool IsConnected { get; }

    public TimeSpan RemainingTime { get; set; }
}