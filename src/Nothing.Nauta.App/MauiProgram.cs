namespace Nothing.Nauta.App
{
    using Blorc.Services;

    using Microsoft.EntityFrameworkCore;

    using MudBlazor.Services;

    using Nothing.Nauta.App.Data;
    using Nothing.Nauta.App.Services;
    using Nothing.Nauta.App.Services.Interfaces;
    using Nothing.Nauta.Interfaces;

    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>();

            builder.Services.AddBlorcCore();
            builder.Services.AddMudServices();
            builder.Services.AddMauiBlazorWebView();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif

            builder.Services.AddDbContext<AppDbContext>();

            builder.Services.AddSingleton<IViewModelFactory, ViewModelFactory>();
            builder.Services.AddSingleton<ISessionManager, SessionManager>();
            builder.Services.AddSingleton<ISessionHandler, SessionHandler>();
            builder.Services.AddSingleton<IAccountManagement, AccountManagement>();
            builder.Services.AddSingleton(_ => SecureStorage.Default);

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