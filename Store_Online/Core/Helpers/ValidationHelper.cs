using System.Text.RegularExpressions;

namespace Store_Online.Core.Helpers
{
    public static class ValidationHelper
    {
        public static bool IsNullOrWhiteSpace(string? value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsValidEmail(string? email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            return Regex.IsMatch(
                email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool HasMinLength(string? value, int length)
        {
            return !string.IsNullOrWhiteSpace(value)
                   && value.Length >= length;
        }
    }
}
