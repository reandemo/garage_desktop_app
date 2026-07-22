using System;

namespace Store_Online.Core.Localization
{
    /// <summary>
    /// Global language notification service.
    /// </summary>
    public static class LanguageService
    {
        /// <summary>
        /// Raised whenever the application language changes.
        /// </summary>
        public static event EventHandler? LanguageChanged;

        internal static void NotifyLanguageChanged()
        {
            LanguageChanged?.Invoke(null, EventArgs.Empty);
        }
    }
}
