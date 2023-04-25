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
        context.Succeed(requirement);
        if (await this.fingerprint.IsAvailableAsync())
        {
            var authenticationRequestConfiguration = new AuthenticationRequestConfiguration("Nauta Session", "Use your fingerprint");
            var fingerprintAuthenticationResult = await this.fingerprint.AuthenticateAsync(authenticationRequestConfiguration);
            if (!fingerprintAuthenticationResult.Authenticated)
            {
                context.Fail();
            }
        }
    }
}