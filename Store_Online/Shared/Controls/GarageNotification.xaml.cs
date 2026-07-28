using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Store_Online.Shared.Controls
{
    public partial class GarageNotification : UserControl
    {
        public GarageNotification()
        {
            InitializeComponent();

            CloseCommand = new RelayCommand(_ =>
            {
                Visibility = Visibility.Collapsed;
            });

            Loaded += GarageNotification_Loaded;
        }

        private void GarageNotification_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateAppearance();
        }

        #region Title

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(
                nameof(Title),
                typeof(string),
                typeof(GarageNotification),
                new PropertyMetadata("Notification"));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        #endregion

        #region Message

        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register(
                nameof(Message),
                typeof(string),
                typeof(GarageNotification),
                new PropertyMetadata(string.Empty));

        public string Message
        {
            get => (string)GetValue(MessageProperty);
            set => SetValue(MessageProperty, value);
        }

        #endregion

        #region Type

        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register(
                nameof(Type),
                typeof(NotificationType),
                typeof(GarageNotification),
                new PropertyMetadata(NotificationType.Info, OnTypeChanged));

        public NotificationType Type
        {
            get => (NotificationType)GetValue(TypeProperty);
            set => SetValue(TypeProperty, value);
        }

        #endregion

        #region BackgroundBrush

        private static readonly DependencyPropertyKey BackgroundBrushPropertyKey =
            DependencyProperty.RegisterReadOnly(
                nameof(BackgroundBrush),
                typeof(Brush),
                typeof(GarageNotification),
                new PropertyMetadata(Brushes.SteelBlue));

        public static readonly DependencyProperty BackgroundBrushProperty =
            BackgroundBrushPropertyKey.DependencyProperty;

        public Brush BackgroundBrush
        {
            get => (Brush)GetValue(BackgroundBrushProperty);
            private set => SetValue(BackgroundBrushPropertyKey, value);
        }

        #endregion

        #region IconKind

        private static readonly DependencyPropertyKey IconKindPropertyKey =
            DependencyProperty.RegisterReadOnly(
                nameof(IconKind),
                typeof(PackIconKind),
                typeof(GarageNotification),
                new PropertyMetadata(PackIconKind.Information));

        public static readonly DependencyProperty IconKindProperty =
            IconKindPropertyKey.DependencyProperty;

        public PackIconKind IconKind
        {
            get => (PackIconKind)GetValue(IconKindProperty);
            private set => SetValue(IconKindPropertyKey, value);
        }

        #endregion

        #region CloseCommand

        public ICommand CloseCommand { get; }

        #endregion

        private static void OnTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((GarageNotification)d).UpdateAppearance();
        }

        private void UpdateAppearance()
        {
            switch (Type)
            {
                case NotificationType.Success:
                    BackgroundBrush = (Brush)Application.Current.FindResource("SuccessBrush");
                    IconKind = PackIconKind.CheckCircle;
                    break;

                case NotificationType.Warning:
                    BackgroundBrush = (Brush)Application.Current.FindResource("WarningBrush");
                    IconKind = PackIconKind.Alert;
                    break;

                case NotificationType.Error:
                    BackgroundBrush = (Brush)Application.Current.FindResource("DangerBrush");
                    IconKind = PackIconKind.CloseCircle;
                    break;

                default:
                    BackgroundBrush = (Brush)Application.Current.FindResource("InfoBrush");
                    IconKind = PackIconKind.Information;
                    break;
            }
        }

        private sealed class RelayCommand : ICommand
        {
            private readonly System.Action<object> _execute;

            public RelayCommand(System.Action<object> execute)
            {
                _execute = execute;
            }

            public bool CanExecute(object parameter) => true;

            public void Execute(object parameter) => _execute(parameter);

            public event System.EventHandler CanExecuteChanged
            {
                add { }
                remove { }
            }
        }
    }

    public enum NotificationType
    {
        Info,
        Success,
        Warning,
        Error
    }
}