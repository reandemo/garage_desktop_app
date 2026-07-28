using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Store_Online.Shared.Controls
{
    public partial class GarageStatusBadge : UserControl
    {
        public GarageStatusBadge()
        {
            InitializeComponent();
            Loaded += GarageStatusBadge_Loaded;
        }

        private void GarageStatusBadge_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateBrush();
        }

        #region Text

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(
                nameof(Text),
                typeof(string),
                typeof(GarageStatusBadge),
                new PropertyMetadata("Ready"));

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        #endregion

        #region Status

        public static readonly DependencyProperty StatusProperty =
            DependencyProperty.Register(
                nameof(Status),
                typeof(StatusBadgeType),
                typeof(GarageStatusBadge),
                new PropertyMetadata(StatusBadgeType.Success, OnStatusChanged));

        public StatusBadgeType Status
        {
            get => (StatusBadgeType)GetValue(StatusProperty);
            set => SetValue(StatusProperty, value);
        }

        #endregion

        #region BadgeBackground

        private static readonly DependencyPropertyKey BadgeBackgroundPropertyKey =
            DependencyProperty.RegisterReadOnly(
                nameof(BadgeBackground),
                typeof(Brush),
                typeof(GarageStatusBadge),
                new PropertyMetadata(Brushes.ForestGreen));

        public static readonly DependencyProperty BadgeBackgroundProperty =
            BadgeBackgroundPropertyKey.DependencyProperty;

        public Brush BadgeBackground
        {
            get => (Brush)GetValue(BadgeBackgroundProperty);
            private set => SetValue(BadgeBackgroundPropertyKey, value);
        }

        #endregion

        private static void OnStatusChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((GarageStatusBadge)d).UpdateBrush();
        }

        private void UpdateBrush()
        {
            Brush brush;

            switch (Status)
            {
                case StatusBadgeType.Success:
                    brush = (Brush)Application.Current.FindResource("SuccessBrush");
                    break;

                case StatusBadgeType.Warning:
                    brush = (Brush)Application.Current.FindResource("WarningBrush");
                    break;

                case StatusBadgeType.Danger:
                    brush = (Brush)Application.Current.FindResource("DangerBrush");
                    break;

                case StatusBadgeType.Info:
                    brush = (Brush)Application.Current.FindResource("InfoBrush");
                    break;

                default:
                    brush = Brushes.Gray;
                    break;
            }

            BadgeBackground = brush;
        }
    }

    public enum StatusBadgeType
    {
        Success,
        Warning,
        Danger,
        Info
    }
}