using Store_Online.Shared.Services;

namespace Store_Online.Shared.Dialogs
{
    public static class ValidationHelper
    {
        #region Required

        public static void Required(string fieldName)
        {
            AlertService.ValidateInput(
                $"{fieldName} is required.");
        }

        #endregion

        #region Duplicate

        public static void Duplicate(string fieldName)
        {
            AlertService.ValidateInput(
                $"{fieldName} already exists.",
                "Duplicate Record",
                $"Please use another {fieldName.ToLower()}.");
        }

        #endregion

        #region Email

        public static void InvalidEmail()
        {
            AlertService.ValidateInput(
                "Invalid email address.",
                "Validate Input",
                "Please enter a valid email address.");
        }

        #endregion

        #region Phone

        public static void InvalidPhone()
        {
            AlertService.ValidateInput(
                "Invalid phone number.",
                "Validate Input",
                "Please enter a valid phone number.");
        }

        #endregion

        #region Quantity

        public static void InvalidQuantity()
        {
            AlertService.ValidateInput(
                "Quantity must be greater than zero.",
                "Validate Input",
                "Please enter a valid quantity.");
        }

        #endregion

        #region Price

        public static void InvalidPrice()
        {
            AlertService.ValidateInput(
                "Price must be greater than zero.",
                "Validate Input",
                "Please enter a valid price.");
        }

        #endregion

        #region Password

        public static void InvalidPassword()
        {
            AlertService.ValidateInput(
                "Password is invalid.",
                "Validate Input",
                "Please check your password.");
        }

        #endregion

        #region Date

        public static void InvalidDate()
        {
            AlertService.ValidateInput(
                "Invalid date.",
                "Validate Input",
                "Please select a valid date.");
        }

        #endregion

        #region Selection

        public static void Select(string fieldName)
        {
            AlertService.ValidateInput(
                $"Please select {fieldName}.",
                "Selection Required",
                "A selection is required before continuing.");
        }

        #endregion

        #region Length

        public static void TooShort(string fieldName, int minimum)
        {
            AlertService.ValidateInput(
                $"{fieldName} is too short.",
                "Validate Input",
                $"Minimum length is {minimum} characters.");
        }

        public static void TooLong(string fieldName, int maximum)
        {
            AlertService.ValidateInput(
                $"{fieldName} is too long.",
                "Validate Input",
                $"Maximum length is {maximum} characters.");
        }

        #endregion
    }
}
