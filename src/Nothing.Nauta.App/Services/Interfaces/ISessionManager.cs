namespace Nothing.Nauta.App.Services.Interfaces;

using Nothing.Nauta.App.Data;

public interface ISessionManager
{
    event EventHandler<SessionManagerStateChangeEventArg> StateChanged;

    Task<bool> IsConnectedAsync(AccountInfo accountInfo);

    Task<Dictionary<string, string>?> GetSessionDataAsync();

    Task<TimeSpan> GetRemainingTimeAsync();

    Task OpenAsync(string userName, string? password);

    Task CloseAsync();

    Task ForceCloseAsync();

    Task<bool> IsConnectedAsync();
}

public class SessionManagerStateChangeEventArg
{
    public bool IsConnected { get; }

    public SessionManagerStateChangeEventArg(bool isConnected)
    {
        this.IsConnected = isConnected;
    }
}