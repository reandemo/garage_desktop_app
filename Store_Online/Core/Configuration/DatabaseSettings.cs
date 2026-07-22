namespace Store_Online.Core.Configuration
{
    public class DatabaseSettings
    {
        public string Provider { get; set; } = "SqlServer";

        public int CommandTimeout { get; set; } = 300;

        public bool EnableLogging { get; set; }

        public int MaxRetryCount { get; set; } = 3;

        public int RetryDelay { get; set; } = 5;


        public string Server { get; set; } = "";

        public string Database { get; set; } = "";

        public string User { get; set; } = "";

        public string Password { get; set; } = "";

        public string ConnectionString =>
            $"Server={Server};Database={Database};User ID={User};Password={Password};TrustServerCertificate=True;";


    }
}
