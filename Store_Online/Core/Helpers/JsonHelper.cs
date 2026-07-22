using System.Text.Json;

namespace Store_Online.Core.Helpers
{
    public static class JsonHelper
    {
        public static string Serialize<T>(T data)
        {
            return JsonSerializer.Serialize(
                data,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });
        }

        public static T? Deserialize<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
