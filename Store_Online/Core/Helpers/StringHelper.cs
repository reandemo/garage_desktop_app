namespace Store_Online.Core.Helpers
{
    public static class StringHelper
    {
        public static string Capitalize(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            return char.ToUpper(text[0]) + text[1..];
        }

        public static string RemoveSpaces(string text)
        {
            return text.Replace(" ", "");
        }
    }
}
