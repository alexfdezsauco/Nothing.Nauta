namespace Nothing.Nauta.App.Authorization;

using System.Security.Claims;

using Microsoft.AspNetCore.Components.Authorization;

public class FingerprintAuthorizationStateProvider : AuthenticationStateProvider
{
    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        //var user = await _userManager.GetUserAsync<User<Profile>>();
        //if (user is null)
        //{
        //    var principal = new ClaimsPrincipal(new ClaimsIdentity());
        //    return new AuthenticationState(principal);
        //}

        var claims = new List<Claim>();
        //claims.AddRange(user.AsClaims());

        var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(claims, "Fingerprint"));
        return new AuthenticationState(claimsPrincipal);
    }
}