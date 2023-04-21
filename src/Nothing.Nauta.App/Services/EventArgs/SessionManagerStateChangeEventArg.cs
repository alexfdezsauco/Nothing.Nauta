namespace Nothing.Nauta.App.Services.EventArgs;

public class SessionManagerStateChangeEventArg
{
    public bool IsConnected { get; }

    public SessionManagerStateChangeEventArg(bool isConnected)
    {
        IsConnected = isConnected;
    }
}