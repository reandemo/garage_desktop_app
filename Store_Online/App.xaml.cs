using Microsoft.Extensions.DependencyInjection;
using Store_Online.Authentication;
using Store_Online.Core.Configuration;
using Store_Online.Core.Database;
using Store_Online.Core.Localization;
using Store_Online.Core.Security;
using Store_Online.Core.Services;
using Store_Online.Modules.Garage.Repositories;
using Store_Online.Modules.Garage.ViewModels;
using System.IO;
using System.Windows;

namespace Store_Online
{
    public partial class App : Application
    {
        public static IServiceProvider Services { get; private set; } = null!;

        protected override void OnStartup(StartupEventArgs e)
        {
            LanguageManager.LoadSavedLanguage();

            ServiceCollection services = new();

            ConfigureServices(services);

            Services = services.BuildServiceProvider();

#if DEBUG
            // Test reading sys.xml
            DatabaseSettings settings =
                Services.GetRequiredService<DatabaseSettings>();

            //MessageBox.Show(
            //    settings.ConnectionString,
            //    "Database Connection");
#endif

            base.OnStartup(e);
        }

        private void ConfigureServices(IServiceCollection services)
        {
            //---------------------------------------------------------
            // Encryption Options
            //---------------------------------------------------------
            services.AddSingleton(new EncryptionOptions
            {
                Password = "StoreOnline2026@Password",
                Salt = "StoreOnline2026@Salt",
                KeySize = 256,
                Iterations = 100000
            });

            //---------------------------------------------------------
            // Encryption Service
            //---------------------------------------------------------
            services.AddSingleton<IEncryptionService>(provider =>
            {
                EncryptionOptions options =
                    provider.GetRequiredService<EncryptionOptions>();

                return new EncryptionService(options);
            });

            //---------------------------------------------------------
            // Database Settings (Read sys.xml)
            //---------------------------------------------------------
            services.AddSingleton<DatabaseSettings>(provider =>
            {
                string xmlPath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "sys.xml");

                if (!File.Exists(xmlPath))
                {
                    throw new FileNotFoundException(
                        $"Cannot find configuration file:\n{xmlPath}");
                }

                IEncryptionService encryption =
                    provider.GetRequiredService<IEncryptionService>();

                XmlDatabaseReader reader =
                    new XmlDatabaseReader(encryption);

                return reader.Load(xmlPath);
            });

            //---------------------------------------------------------
            // Database Connection Factory
            //---------------------------------------------------------
            services.AddSingleton<DbConnectionFactory>(provider =>
            {
                DatabaseSettings settings =
                    provider.GetRequiredService<DatabaseSettings>();

                return new DbConnectionFactory(settings.ConnectionString);
            });

            //---------------------------------------------------------
            // Garage Module
            //---------------------------------------------------------
            services.AddSingleton<CustomerRepository>();

            services.AddSingleton<CustomerViewModel>();


            //---------------------------------------------------------
            // Services
            //---------------------------------------------------------
            services.AddSingleton<SqlExecutor>();

            services.AddSingleton<LoginHistoryService>();

            services.AddSingleton<ApiService>();

            //---------------------------------------------------------
            // Windows
            //---------------------------------------------------------
            services.AddSingleton<Login>();

        }
    }
}