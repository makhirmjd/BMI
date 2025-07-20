using BMI.ViewModels;
using Microsoft.Extensions.Logging;
using Syncfusion.Licensing;
using Syncfusion.Maui.Core.Hosting;

namespace BMI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            SyncfusionLicenseProvider.RegisterLicense("Mzk1ODgwNkAzMzMwMmUzMDJlMzAzYjMzMzAzYlRoVFZuR1BERGF4aTRzUWVXREhSQ091OXduMXNPQy9GSU5kQnNtdllmL289");

            var builder = MauiApp.CreateBuilder();

            builder.ConfigureSyncfusionCore();

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
            ConfigureServices(builder.Services);

            return builder.Build();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<BMIViewModel>();
        }
    }
}
