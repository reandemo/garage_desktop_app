using System.Globalization;
using System.Threading;
using Store_Online.Core.Configuration;

namespace Store_Online.Core.Localization
{
    public static class LanguageManager
    {
        public static CultureInfo CurrentCulture { get; private set; }
            = CultureInfo.CurrentUICulture;

        public static void ChangeCulture(string cultureName)
        {
            if (string.IsNullOrWhiteSpace(cultureName))
                return;

            if (string.Equals(
                    CurrentCulture.Name,
                    cultureName,
                    StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            CultureInfo culture;

            try
            {
                culture = new CultureInfo(cultureName);
            }
            catch (CultureNotFoundException)
            {
                return;
            }

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            CurrentCulture = culture;

            if (SettingsManager.Current != null)
            {
                SettingsManager.Current.Language = cultureName;
                SettingsManager.Save();
            }

            LanguageService.NotifyLanguageChanged();
        }

        public static void LoadSavedLanguage()
        {
            string? language = SettingsManager.Current?.Language;

            if (string.IsNullOrWhiteSpace(language))
            {
                CurrentCulture = CultureInfo.CurrentUICulture;
                return;
            }

            ChangeCulture(language);
        }
    }
}