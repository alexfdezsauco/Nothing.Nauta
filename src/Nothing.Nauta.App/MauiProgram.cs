// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MauiProgram.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App
{
    using System.Diagnostics;

    using Blorc.Services;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Components.Authorization;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Maui.LifecycleEvents;

    using MudBlazor.Services;

    using Nothing.Nauta.App.Authorization;
    using Nothing.Nauta.App.Data;
    using Nothing.Nauta.App.Services;
    using Nothing.Nauta.App.Services.Interfaces;
    using Nothing.Nauta.Interfaces;

    using Plugin.Fingerprint;

    using Microsoft.Maui.LifecycleEvents;
    using Nothing.Nauta.App.Data.Services.Interfaces;
    using Nothing.Nauta.App.Data.Services;

    /// <summary>
    /// The MAUI program.
    /// </summary>
    public static class MauiProgram
    {
        /// <summary>
        /// Creates maui app.
        /// </summary>
        /// <returns>
        /// The <see cref="MauiApp"/>.
        /// </returns>
        public static MauiApp CreateMauiApp()
        {
            MauiApp? app = null;

            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureLifecycleEvents(
                events =>
                    {
#if ANDROID
                        events.AddAndroid(android => android.OnStart(activity =>
                            {
                                if (app is not null)
                                {
                                    var authenticationService = app.Services.GetRequiredService<IAuthenticationService>();
                                    authenticationService.ExpireSession();
                                }
                            }));
#endif
                    });

            builder.Services.AddBlorcCore();
            builder.Services.AddAuthorizationCore(
                options =>
                    {
                        options.AddPolicy(
                            Policies.Fingerprint,
                            policyBuilder =>
                                {
                                    policyBuilder.AddRequirements(new FingerprintAuthorizationRequirement());
                                });
                    });

            builder.Services.AddSingleton<AuthenticationStateProvider, FingerprintAuthorizationStateProvider>();
            builder.Services.AddScoped<IAuthorizationHandler, FingerprintAuthorizationRequirementHandler>();
            builder.Services.AddSingleton<IAuthenticationService, AuthenticationService>();

            builder.Services.AddMudServices();
            builder.Services.AddMauiBlazorWebView();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif

            builder.Services.AddDbContext<AppDbContext>();

            builder.Services.AddSingleton<IViewModelFactory, ViewModelFactory>();

            builder.Services.AddSingleton<ITimeService, TimeService>();
            builder.Services.AddSingleton<ISessionManager, SessionManager>();
            builder.Services.AddSingleton<ISessionHandler, SessionHandler>();
            builder.Services.AddSingleton<IAccountRepository, AccountRepository>();

            builder.Services.AddSingleton(_ => CrossFingerprint.Current);
            builder.Services.AddSingleton(_ => SecureStorage.Default);
            builder.Services.AddSingleton(_ => DeviceDisplay.Current);

            app = builder.Build();

            var serviceScope = app.Services.CreateScope();
            var appDbContext = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>();
            if (appDbContext.Database.GetPendingMigrations().Any())
            {
                appDbContext.Database.Migrate();
            }

            return app;
        }
    }
}