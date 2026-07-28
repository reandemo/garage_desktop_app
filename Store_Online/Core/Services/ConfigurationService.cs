namespace Store_Online.Core.Services
{
    public class ConfigurationService
    {
        public string AppName => "Store Online";

        public string CompanyName => "REAN-PRO";

        public string Version => "1.0.0";

#if DEBUG
        public string ApiUrl => "https://reanprogramming.com/api/v1/";
#else
        public string ApiUrl => "https://reanprogramming.com/api/v1/";
#endif

        public TimeSpan ApiTimeout => TimeSpan.FromSeconds(30);

        public string DefaultLanguage => "en";

        public bool EnableLogging => true;
    }
}