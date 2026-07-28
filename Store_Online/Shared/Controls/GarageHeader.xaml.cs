using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Store_Online.Shared.Controls
{
    public partial class GarageHeader : UserControl
    {
        public GarageHeader()
        {
            InitializeComponent();
        }

        #region Title

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(
                nameof(Title),
                typeof(string),
                typeof(GarageHeader),
                new PropertyMetadata(string.Empty));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        #endregion

        #region Subtitle

        public static readonly DependencyProperty SubtitleProperty =
            DependencyProperty.Register(
                nameof(Subtitle),
                typeof(string),
                typeof(GarageHeader),
                new PropertyMetadata(string.Empty));

        public string Subtitle
        {
            get => (string)GetValue(SubtitleProperty);
            set => SetValue(SubtitleProperty, value);
        }

        #endregion

        #region Status

        public static readonly DependencyProperty StatusProperty =
            DependencyProperty.Register(
                nameof(Status),
                typeof(string),
                typeof(GarageHeader),
                new PropertyMetadata("Ready"));

        public string Status
        {
            get => (string)GetValue(StatusProperty);
            set => SetValue(StatusProperty, value);
        }

        #endregion

        #region StatusBrush

        public static readonly DependencyProperty StatusBrushProperty =
            DependencyProperty.Register(
                nameof(StatusBrush),
                typeof(Brush),
                typeof(GarageHeader),
                new PropertyMetadata(Brushes.ForestGreen));

        public Brush StatusBrush
        {
            get => (Brush)GetValue(StatusBrushProperty);
            set => SetValue(StatusBrushProperty, value);
        }

        #endregion

        #region IconKind

        public static readonly DependencyProperty IconKindProperty =
            DependencyProperty.Register(
                nameof(IconKind),
                typeof(PackIconKind),
                typeof(GarageHeader),
                new PropertyMetadata(PackIconKind.ViewDashboard));

        public PackIconKind IconKind
        {
            get => (PackIconKind)GetValue(IconKindProperty);
            set => SetValue(IconKindProperty, value);
        }

        #endregion
    }
}