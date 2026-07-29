using System.Text.RegularExpressions;
using Store_Online.Core.Services;

namespace Store_Online.Shared.Helpers
{
    public static class ValidationHelper
    {
        private const string ValidateTitle = "Validate Input";

        public static bool IsNullOrWhiteSpace(string? value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool HasMinLength(string? value, int minimumLength)
        {
            return !string.IsNullOrWhiteSpace(value) &&
                   value.Length >= minimumLength;
        }

        public static bool HasMaxLength(string? value, int maximumLength)
        {
            return string.IsNullOrWhiteSpace(value) ||
                   value.Length <= maximumLength;
        }

        public static bool IsValidEmail(string? email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            return Regex.IsMatch(
                email.Trim(),
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.IgnoreCase);
        }

        public static bool IsValidPhone(string? phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            return Regex.IsMatch(
                phone.Trim(),
                @"^[0-9+\-\s()]{7,20}$");
        }

        public static void Required(string fieldName)
        {
            AlertService.ValidateInput(
                $"{fieldName} is required.");
        }

        public static void Select(string fieldName)
        {
            AlertService.ValidateInput(
                $"Please select {fieldName}.",
                "Selection Required",
                "A selection is required before continuing.");
        }

        public static void Duplicate(string fieldName)
        {
            AlertService.ValidateInput(
                $"{fieldName} already exists.",
                "Duplicate Record",
                $"Please use another {fieldName.ToLower()}.");
        }

        public static void InvalidEmail()
        {
            AlertService.ValidateInput(
                "Invalid email address.",
                ValidateTitle,
                "Please enter a valid email address.");
        }

        public static void InvalidPhone()
        {
            AlertService.ValidateInput(
                "Invalid phone number.",
                ValidateTitle,
                "Please enter a valid phone number.");
        }

        public static void InvalidQuantity()
        {
            AlertService.ValidateInput(
                "Quantity must be greater than zero.",
                ValidateTitle,
                "Please enter a valid quantity.");
        }

        public static void InvalidPrice()
        {
            AlertService.ValidateInput(
                "Price must be greater than zero.",
                ValidateTitle,
                "Please enter a valid price.");
        }

        public static void InvalidPassword()
        {
            AlertService.ValidateInput(
                "Password is invalid.",
                ValidateTitle,
                "Please check your password.");
        }

        public static void InvalidDate()
        {
            AlertService.ValidateInput(
                "Invalid date.",
                ValidateTitle,
                "Please select a valid date.");
        }

        public static void TooShort(string fieldName, int minimumLength)
        {
            AlertService.ValidateInput(
                $"{fieldName} is too short.",
                ValidateTitle,
                $"Minimum length is {minimumLength} characters.");
        }

        public static void TooLong(string fieldName, int maximumLength)
        {
            AlertService.ValidateInput(
                $"{fieldName} is too long.",
                ValidateTitle,
                $"Maximum length is {maximumLength} characters.");
        }

        public static bool ValidateRequired(string? value, string fieldName)
        {
            if (!IsNullOrWhiteSpace(value))
                return true;

            Required(fieldName);
            return false;
        }

        public static bool ValidateEmail(string? email)
        {
            if (IsValidEmail(email))
                return true;

            InvalidEmail();
            return false;
        }

        public static bool ValidatePhone(string? phone)
        {
            if (IsValidPhone(phone))
                return true;

            InvalidPhone();
            return false;
        }

        public static bool ValidateMinLength(string? value, string fieldName, int minimumLength)
        {
            if (HasMinLength(value, minimumLength))
                return true;

            TooShort(fieldName, minimumLength);
            return false;
        }

        public static bool ValidateMaxLength(string? value, string fieldName, int maximumLength)
        {
            if (HasMaxLength(value, maximumLength))
                return true;

            TooLong(fieldName, maximumLength);
            return false;
        }
    }
}
