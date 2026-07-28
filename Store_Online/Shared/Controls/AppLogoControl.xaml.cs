using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Store_Online.Shared.Controls
{
    public partial class AppLogoControl : UserControl
    {
        public AppLogoControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty LogoSourceProperty =
            DependencyProperty.Register(
                nameof(LogoSource),
                typeof(ImageSource),
                typeof(AppLogoControl));

        public ImageSource LogoSource
        {
            get => (ImageSource)GetValue(LogoSourceProperty);
            set => SetValue(LogoSourceProperty, value);
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(
                nameof(Title),
                typeof(string),
                typeof(AppLogoControl),
                new PropertyMetadata(string.Empty));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly DependencyProperty SubtitleProperty =
            DependencyProperty.Register(
                nameof(Subtitle),
                typeof(string),
                typeof(AppLogoControl),
                new PropertyMetadata(string.Empty));

        public string Subtitle
        {
            get => (string)GetValue(SubtitleProperty);
            set => SetValue(SubtitleProperty, value);
        }

        public static readonly DependencyProperty LogoSizeProperty =
            DependencyProperty.Register(
                nameof(LogoSize),
                typeof(double),
                typeof(AppLogoControl),
                new PropertyMetadata(100d));

        public double LogoSize
        {
            get => (double)GetValue(LogoSizeProperty);
            set => SetValue(LogoSizeProperty, value);
        }
    }
}
