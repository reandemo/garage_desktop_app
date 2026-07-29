using System.IO;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Store_Online.Authentication;
using Store_Online.Core.Configuration;
using Store_Online.Core.Database;
using Store_Online.Core.Interfaces;
using Store_Online.Core.Localization;
using Store_Online.Core.Logging;
using Store_Online.Core.Security;
using Store_Online.Core.Services;
using Store_Online.Modules.Coffee.Services;
using Store_Online.Modules.Garage.Pages;
using Store_Online.Modules.Garage.Repositories;

namespace Store_Online
{
    public partial class App : Application
    {
        public static IServiceProvider Services { get; private set; } = null!;

        public static T GetService<T>() where T : notnull =>
            Services.GetRequiredService<T>();

        protected override void OnStartup(StartupEventArgs e)
        {
            LanguageManager.LoadSavedLanguage();

            ServiceCollection services = new();

            ConfigureServices(services);

            Services = services.BuildServiceProvider();

#if DEBUG
            _ = GetService<DatabaseSettings>();
#endif

            base.OnStartup(e);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            string xmlPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "sys.xml");

            services.AddSingleton(new EncryptionOptions
            {
                Password = "StoreOnline2026@Password",
                Salt = "StoreOnline2026@Salt",
                KeySize = 256,
                Iterations = 100000
            });

            services.AddSingleton<IEncryptionService, EncryptionService>();
            services.AddSingleton<ConfigurationService>();
            services.AddSingleton<XmlDatabaseReader>();

            services.AddSingleton(provider =>
            {
                if (!File.Exists(xmlPath))
                    throw new FileNotFoundException(
                        $"Configuration file not found:{Environment.NewLine}{xmlPath}");

                return provider
                    .GetRequiredService<XmlDatabaseReader>()
                    .Load(xmlPath);
            });

            services.AddSingleton(provider =>
                new DbConnectionFactory(
                    provider.GetRequiredService<DatabaseSettings>().ConnectionString));

            services.AddSingleton<SqlExecutor>();
            services.AddSingleton<CustomerRepository>();
            services.AddSingleton<LanguageRepository>();
            services.AddSingleton<LoginHistoryService>();
            services.AddSingleton<DatabaseLogger>();

            services.AddSingleton<ApiService>();
            services.AddSingleton<IApiService>(provider =>
                provider.GetRequiredService<ApiService>());

            services.AddTransient<ProductService>();
            services.AddSingleton<Login>();
            services.AddTransient<GarageCustomerRegistration>();
        }
    }
}
