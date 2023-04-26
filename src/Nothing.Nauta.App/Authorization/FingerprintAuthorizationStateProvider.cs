namespace Nothing.Nauta.App.Authorization;

using System.Security.Claims;

using Microsoft.AspNetCore.Components.Authorization;

public class FingerprintAuthorizationStateProvider : AuthenticationStateProvider
{
    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(Array.Empty<Claim>(), "Fingerprint"));
        return Task.FromResult(new AuthenticationState(claimsPrincipal));
    }
}