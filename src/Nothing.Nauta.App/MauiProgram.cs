using Nothing.Nauta.App.Data;

namespace Nothing.Nauta.App
{
    using Microsoft.EntityFrameworkCore;

    using MudBlazor.Services;

    using Nothing.Nauta.App.Models;
    using Nothing.Nauta.App.Services;
    using Nothing.Nauta.App.Services.Interfaces;
    using Nothing.Nauta.Interfaces;

    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>();
                //.ConfigureFonts(fonts =>
                //{
                //    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                //});

            builder.Services.AddMudServices();

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif

            builder.Services.AddDbContext<AppDbContext>();
            
            builder.Services.AddSingleton<ISessionHandler, SessionHandler>();
            builder.Services.AddSingleton<IAccountManagement, AccountManagement>();
            builder.Services.AddSingleton(_ => SecureStorage.Default);

            builder.Services.AddSingleton<WeatherForecastService>();

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