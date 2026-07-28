using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Store_Online.Shared.Controls
{
    public partial class GarageDashboardCard : UserControl
    {
        public GarageDashboardCard()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(nameof(Title), typeof(string), typeof(GarageDashboardCard));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly DependencyProperty SubtitleProperty =
            DependencyProperty.Register(nameof(Subtitle), typeof(string), typeof(GarageDashboardCard));

        public string Subtitle
        {
            get => (string)GetValue(SubtitleProperty);
            set => SetValue(SubtitleProperty, value);
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(nameof(Value), typeof(string), typeof(GarageDashboardCard));

        public string Value
        {
            get => (string)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        public static readonly DependencyProperty FooterProperty =
            DependencyProperty.Register(nameof(Footer), typeof(string), typeof(GarageDashboardCard));

        public string Footer
        {
            get => (string)GetValue(FooterProperty);
            set => SetValue(FooterProperty, value);
        }

        public static readonly DependencyProperty TrendTextProperty =
            DependencyProperty.Register(nameof(TrendText), typeof(string), typeof(GarageDashboardCard));

        public string TrendText
        {
            get => (string)GetValue(TrendTextProperty);
            set => SetValue(TrendTextProperty, value);
        }

        public static readonly DependencyProperty IconKindProperty =
            DependencyProperty.Register(nameof(IconKind), typeof(PackIconKind), typeof(GarageDashboardCard), new PropertyMetadata(PackIconKind.ChartBar));

        public PackIconKind IconKind
        {
            get => (PackIconKind)GetValue(IconKindProperty);
            set => SetValue(IconKindProperty, value);
        }

        public static readonly DependencyProperty TrendIconProperty =
            DependencyProperty.Register(nameof(TrendIcon), typeof(PackIconKind), typeof(GarageDashboardCard), new PropertyMetadata(PackIconKind.TrendingUp));

        public PackIconKind TrendIcon
        {
            get => (PackIconKind)GetValue(TrendIconProperty);
            set => SetValue(TrendIconProperty, value);
        }

        public static readonly DependencyProperty IconBackgroundProperty =
            DependencyProperty.Register(nameof(IconBackground), typeof(Brush), typeof(GarageDashboardCard));

        public Brush IconBackground
        {
            get => (Brush)GetValue(IconBackgroundProperty);
            set => SetValue(IconBackgroundProperty, value);
        }

        public static readonly DependencyProperty TrendBrushProperty =
            DependencyProperty.Register(nameof(TrendBrush), typeof(Brush), typeof(GarageDashboardCard));

        public Brush TrendBrush
        {
            get => (Brush)GetValue(TrendBrushProperty);
            set => SetValue(TrendBrushProperty, value);
        }
    }
}