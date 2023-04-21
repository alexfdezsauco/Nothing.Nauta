namespace Nothing.Nauta.App.Services.Interfaces;

using Nothing.Nauta.App.Data;
using Nothing.Nauta.App.Services.EventArgs;

public interface ISessionManager
{
    event EventHandler<SessionManagerStateChangeEventArg> StateChanged;

    Task<bool> IsConnectedAsync(AccountInfo accountInfo);

    Task<Dictionary<string, string>?> GetSessionDataAsync();

    Task<(TimeSpan, TimeSpan)> GetTimeAsync();

    Task OpenAsync(string userName, string? password);

    Task CloseAsync();

    Task ForceCloseAsync();

    Task<bool> IsConnectedAsync();
}