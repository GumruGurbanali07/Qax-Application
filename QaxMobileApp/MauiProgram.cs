using Microsoft.Extensions.Logging;
using QaxMobileApp.Repository.Abstract;
//using QaxMobileApp.Repository.Concrete;

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

            return builder.Build();
        }
        //public static void ConfigureServices(IServiceCollection services)
        //{
            
        //    services.AddSingleton<ILoginService, LoginService>();
        //    services.AddSingleton<IParentLoginService, ParentLoginService>();
        //}
    }

}