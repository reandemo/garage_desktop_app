using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Store_Online.Shared.Controls
{
    public partial class GarageStatisticCard : UserControl
    {
        public GarageStatisticCard()
        {
            InitializeComponent();
        }

        #region Title

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(
                nameof(Title),
                typeof(string),
                typeof(GarageStatisticCard),
                new PropertyMetadata(string.Empty));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        #endregion

        #region Value

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(
                nameof(Value),
                typeof(string),
                typeof(GarageStatisticCard),
                new PropertyMetadata("0"));

        public string Value
        {
            get => (string)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        #endregion

        #region Footer

        public static readonly DependencyProperty FooterProperty =
            DependencyProperty.Register(
                nameof(Footer),
                typeof(string),
                typeof(GarageStatisticCard),
                new PropertyMetadata(string.Empty));

        public string Footer
        {
            get => (string)GetValue(FooterProperty);
            set => SetValue(FooterProperty, value);
        }

        #endregion

        #region IconKind

        public static readonly DependencyProperty IconKindProperty =
            DependencyProperty.Register(
                nameof(IconKind),
                typeof(PackIconKind),
                typeof(GarageStatisticCard),
                new PropertyMetadata(PackIconKind.ChartBar));

        public PackIconKind IconKind
        {
            get => (PackIconKind)GetValue(IconKindProperty);
            set => SetValue(IconKindProperty, value);
        }

        #endregion

        #region IconBackground

        public static readonly DependencyProperty IconBackgroundProperty =
            DependencyProperty.Register(
                nameof(IconBackground),
                typeof(Brush),
                typeof(GarageStatisticCard),
                new PropertyMetadata(Brushes.DodgerBlue));

        public Brush IconBackground
        {
            get => (Brush)GetValue(IconBackgroundProperty);
            set => SetValue(IconBackgroundProperty, value);
        }

        #endregion

        #region TrendBrush

        public static readonly DependencyProperty TrendBrushProperty =
            DependencyProperty.Register(
                nameof(TrendBrush),
                typeof(Brush),
                typeof(GarageStatisticCard),
                new PropertyMetadata(Brushes.ForestGreen));

        public Brush TrendBrush
        {
            get => (Brush)GetValue(TrendBrushProperty);
            set => SetValue(TrendBrushProperty, value);
        }

        #endregion
    }
}