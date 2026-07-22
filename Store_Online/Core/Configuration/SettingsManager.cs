namespace Store_Online.Core.Configuration;

public static class SettingsManager
{
    public static AppSettings Current { get; private set; }
        = SettingsService.Load();

    public static void Save()
    {
        SettingsService.Save(Current);
    }
}
