using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
namespace Store_Online.Shared.Notifications
{
    public partial class NotificationWindow : Window
    {
        public NotificationWindow(
   string title,
   string message,
   NotificationType type)
        {
            InitializeComponent();

            txtTitle.Text = title;
            txtMessage.Text = message;

            switch (type)
            {
                case NotificationType.Success:
                    MainBorder.Background =
                        new SolidColorBrush(
                            (Color)ColorConverter.ConvertFromString("#0F172A"));

                    IconBorder.Background =
                        new SolidColorBrush(
                            (Color)ColorConverter.ConvertFromString("#22C55E"));

                    txtIcon.Text = "✓";
                    break;

                case NotificationType.Error:
                    MainBorder.Background =
                        new SolidColorBrush(
                            (Color)ColorConverter.ConvertFromString("#0F172A"));

                    IconBorder.Background =
                        new SolidColorBrush(
                            (Color)ColorConverter.ConvertFromString("#EF4444"));

                    txtIcon.Text = "✕";
                    break;

                case NotificationType.Warning:
                    MainBorder.Background =
                        new SolidColorBrush(
                            (Color)ColorConverter.ConvertFromString("#0F172A"));

                    IconBorder.Background =
                        new SolidColorBrush(
                            (Color)ColorConverter.ConvertFromString("#F59E0B"));

                    txtIcon.Text = "⚠";
                    break;

                case NotificationType.Info:
                    MainBorder.Background =
                        new SolidColorBrush(
                            (Color)ColorConverter.ConvertFromString("#0F172A"));

                    IconBorder.Background =
                        new SolidColorBrush(
                            (Color)ColorConverter.ConvertFromString("#3B82F6"));

                    txtIcon.Text = "ℹ";
                    break;
            }

            // Start timer when window loads
            Loaded += NotificationWindow_Loaded;
        }
        private static int _notificationCount = 0;
        private void CloseNotification()
        {
            DoubleAnimation fade = new()
            {
                From = 1,
                To = 0,
                Duration = TimeSpan.FromMilliseconds(300)
            };

            fade.Completed += (s, e) =>
            {
                _notificationCount--;
                Close();
            };

            BeginAnimation(OpacityProperty, fade);
        }
        private async void NotificationWindow_Loaded(
    object sender,
    RoutedEventArgs e)
        {
            if (_notificationCount >= 3)
            {
                Close();
                return;
            }

            int index = _notificationCount++;

            Left = SystemParameters.WorkArea.Width - Width - 20;

            Top = 20 + (index * (Height + 10));

            await Task.Delay(5000);

            CloseNotification();
        }
        private void MainBorder_MouseLeftButtonDown(
    object sender,
    System.Windows.Input.MouseButtonEventArgs e)
        {
            Close();
        }

        private void SetSuccess()
        {
            IconBorder.Background = Brushes.Green;
            txtIcon.Text = "✓";
        }

        private void SetError()
        {
            IconBorder.Background = Brushes.Red;
            txtIcon.Text = "✕";
        }

        private void SetWarning()
        {
            IconBorder.Background = Brushes.Orange;
            txtIcon.Text = "⚠";
        }

        private void SetInfo()
        {
            IconBorder.Background = Brushes.DodgerBlue;
            txtIcon.Text = "ℹ";
        }


        private void btnClose_Click(
    object sender,
    RoutedEventArgs e)
        {
            Close();
        }
    }
}
