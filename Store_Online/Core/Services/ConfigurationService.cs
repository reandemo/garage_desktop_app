namespace Store_Online.Core.Services
{
    public class ConfigurationService
    {
        public string AppName => "Store Online";

        public string CompanyName => "REAN-PRO";

        public string Version => "1.0.0";

        // Change this later for Production
        public string ApiUrl => "https://localhost:5001/api";
    }
}
