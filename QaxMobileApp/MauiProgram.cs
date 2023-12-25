using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;
using QaxMobileApp.DbContext;
//using QaxMobileApp.Repository.Abstract;
using System.IO; // Add this using directive for Directory.GetCurrentDirectory

namespace QaxMobileApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            // Retrieve IConfiguration instance
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            // Configure services with IConfiguration
            ConfigureServices(builder.Services, configuration);

            return builder.Build();
        }

        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            // Existing code...

            // Add DbContext configuration using the connection string from appsettings.json
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("QaxApp")));

            // Existing code...
        }
    }
}
