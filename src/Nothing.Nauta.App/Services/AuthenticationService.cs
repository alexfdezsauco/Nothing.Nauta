using Nothing.Nauta.App.Services.Interfaces;

namespace Nothing.Nauta.App.Services;

public class AuthenticationService : IAuthenticationService
{
    public event EventHandler? SessionExpired;

    public void ExpireSession()
    {
        this.OnSessionExpired();
    }

    protected virtual void OnSessionExpired()
    {
        this.SessionExpired?.Invoke(this, System.EventArgs.Empty);
    }
}