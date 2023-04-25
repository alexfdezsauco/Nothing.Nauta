// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MauiProgram.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App
{
    using Blorc.Services;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Components.Authorization;
    using Microsoft.EntityFrameworkCore;

    using MudBlazor.Services;

    using Nothing.Nauta.App.Authorization;
    using Nothing.Nauta.App.Data;
    using Nothing.Nauta.App.Services;
    using Nothing.Nauta.App.Services.Interfaces;
    using Nothing.Nauta.Interfaces;

    using Plugin.Fingerprint;

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
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>();

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

            var app = builder.Build();

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