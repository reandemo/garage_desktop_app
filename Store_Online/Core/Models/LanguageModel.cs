using System;

namespace Store_Online.Models
{
    public class LanguageModel
    {
        public long Id { get; set; }

        public string LanguageCode { get; set; } = string.Empty;

        public string CultureCode { get; set; } = string.Empty;

        public string LanguageName { get; set; } = string.Empty;

        public string NativeName { get; set; } = string.Empty;

        public string ResourceFile { get; set; } = string.Empty;

        public string FlagIcon { get; set; } = string.Empty;

        public int SortOrder { get; set; }

        public bool IsDefault { get; set; }

        public bool IsActive { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public override string ToString()
        {
            return NativeName;
        }
    }
}