namespace Store_Online.Core.Localization
{
    using System;
    using System.ComponentModel;
    using System.Resources;
    using Store_Online.Resources.Languages;

    public sealed class ResourceProvider : INotifyPropertyChanged, IDisposable
    {
        private static readonly ResourceManager ResourceManager = Strings.ResourceManager;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ResourceProvider()
        {
            LanguageService.LanguageChanged += OnLanguageChanged;
        }

        private void OnLanguageChanged(object? sender, EventArgs e)
        {
            // Refresh all bindings when the language changes
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string.Empty));
        }

        public string this[string key]
        {
            get
            {
                return ResourceManager.GetString(key, LanguageManager.CurrentCulture)
                           ?? $"##{key}##";
            }
        }
        public void Dispose()
        {
            LanguageService.LanguageChanged -= OnLanguageChanged;
        }
    }
}
