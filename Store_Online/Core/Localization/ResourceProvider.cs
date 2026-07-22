using Store_Online.Resources.Languages;
using System;
using System.ComponentModel;
using System.Resources;

namespace Store_Online.Core.Localization
{
    /// <summary>
    /// Provides localized resources for WPF bindings.
    /// Usage:
    /// Text="{Binding [APP_TITLE], Source={StaticResource Lang}"
    /// </summary>
    public class ResourceProvider : INotifyPropertyChanged
    {
        private readonly ResourceManager _resourceManager;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ResourceProvider()
        {
            _resourceManager = Strings.ResourceManager;

            LanguageService.LanguageChanged += OnLanguageChanged;
        }

        private void OnLanguageChanged(object? sender, EventArgs e)
        {
            // Refresh all bindings when the language changes
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }

        public string this[string key]
        {
            get
            {
                return _resourceManager.GetString(key, LanguageManager.CurrentCulture)
                       ?? $"##{key}##";
            }
        }
    }
}
