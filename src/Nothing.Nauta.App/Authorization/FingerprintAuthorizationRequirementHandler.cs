namespace Nothing.Nauta.App.Authorization;

using Microsoft.AspNetCore.Authorization;
using Plugin.Fingerprint.Abstractions;

public class FingerprintAuthorizationRequirementHandler : AuthorizationHandler<FingerprintAuthorizationRequirement>
{
    private readonly IFingerprint fingerprint;

    public FingerprintAuthorizationRequirementHandler(IFingerprint fingerprint)
    {
        this.fingerprint = fingerprint;
    }

    protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, FingerprintAuthorizationRequirement requirement)
    {
        // Required to display devices authentication request controls (fingerprint)
        context.Succeed(requirement);

        if (await this.fingerprint.IsAvailableAsync())
        {
            var authenticationRequestConfiguration = new AuthenticationRequestConfiguration("Nauta Session", "Please unlock with your fingerprint to proceed");
            var authenticationResult = await this.fingerprint.AuthenticateAsync(authenticationRequestConfiguration);
            if (!authenticationResult.Authenticated)
            {
                context.Fail();
            }
        }
    }
}