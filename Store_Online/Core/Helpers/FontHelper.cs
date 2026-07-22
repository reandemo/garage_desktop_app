using System;
using System.Windows.Media;

namespace Store_Online.Core.Helpers
{
    public static class FontHelper
    {
        public static FontFamily AppFont =>
            new FontFamily("Roboto Mono");

        public static FontFamily KhmerFont =>
            new FontFamily(
                new Uri("pack://application:,,,/"),
                "./Shared/Assets/Fonts/#Khmer OS");

        public static FontFamily HandFont =>
            new FontFamily(
                new Uri("pack://application:,,,/"),
                "./Shared/Assets/Fonts/#ASvadek FastHand");
    }
}
