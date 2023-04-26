namespace Nothing.Nauta.App.Services.Interfaces;

public interface IAuthenticationService
{
    event EventHandler SessionExpired;

    void ExpireSession();
}