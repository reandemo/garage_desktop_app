namespace Store_Online.Core.Configuration;

public class AppSettings
{
    public string Language { get; set; } = "en-US";

    public string Theme { get; set; } = "Light";

    public string Currency { get; set; } = "USD";

    public bool RememberLogin { get; set; } = true;

    public string LastBranch { get; set; } = "";

    public DatabaseSettings Database { get; set; } = new();


}
