using System.Globalization;
using System.Threading;
using Store_Online.Core.Configuration;
using Store_Online.Core.Helpers;

namespace Store_Online.Core.Localization
{
    /// <summary>
    /// Handles current application language.
    /// </summary>
    public static class LanguageManager
    {
        /// <summary>
        /// Current culture.
        /// </summary>
        public static CultureInfo CurrentCulture { get; private set; }
            = CultureInfo.CurrentUICulture;

        /// <summary>
        /// Change application language.
        /// </summary>
        public static void ChangeCulture(string cultureName)
        {
            if (string.IsNullOrWhiteSpace(cultureName))
                return;

            CultureInfo culture = new(cultureName);

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            CurrentCulture = culture;

            // Save language
            SettingsManager.Current.Language = cultureName;
            SettingsManager.Save();

            // Refresh UI
            LanguageService.NotifyLanguageChanged();
        }

        /// <summary>
        /// Load saved language.
        /// </summary>
        public static void LoadSavedLanguage()
        {
            ChangeCulture(SettingsManager.Current.Language);
        }
    }
}
