using System.IO;
using System.Text.Json;

namespace Store_Online.Core.Configuration;

public static class SettingsService
{
    private static readonly string Folder =
        Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData),
            "Store_Online");

    private static readonly string FileName =
        Path.Combine(Folder, "settings.json");

    public static AppSettings Load()
    {
        if (!Directory.Exists(Folder))
            Directory.CreateDirectory(Folder);

        if (!File.Exists(FileName))
        {
            var settings = new AppSettings();

            Save(settings);

            return settings;
        }

        try
        {
            string json = File.ReadAllText(FileName);

            return JsonSerializer.Deserialize<AppSettings>(json)
                   ?? new AppSettings();
        }
        catch
        {
            var settings = new AppSettings();

            Save(settings);

            return settings;
        }
    }

    public static void Save(AppSettings settings)
    {
        if (!Directory.Exists(Folder))
            Directory.CreateDirectory(Folder);

        var json = JsonSerializer.Serialize(
            settings,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });

        File.WriteAllText(FileName, json);
    }
}
