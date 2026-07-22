using System;

namespace Store_Online.Core.Localization
{
    /// <summary>
    /// Event arguments for language changes.
    /// </summary>
    public sealed class LanguageChangedEvent : EventArgs
    {
        public string CultureName { get; }

        public LanguageChangedEvent(string cultureName)
        {
            CultureName = cultureName;
        }
    }
}
