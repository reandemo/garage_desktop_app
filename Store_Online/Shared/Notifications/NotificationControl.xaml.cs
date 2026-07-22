using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Store_Online.Shared.Notifications;
/// <summary>
/// Interaction logic for NotificationControl.xaml
/// </summary>
public partial class NotificationControl : UserControl
{
    public NotificationControl()
    {
        InitializeComponent();
    }

    public async Task ShowAsync(
        string message,
        NotificationType type)
    {
        txtMessage.Text = message;

        switch (type)
        {
            case NotificationType.Success:

                MainBorder.Background =
                    new SolidColorBrush(
                        (Color)ColorConverter.ConvertFromString("#ECFDF5"));

                MainBorder.BorderBrush =
                    new SolidColorBrush(
                        (Color)ColorConverter.ConvertFromString("#86EFAC"));

                txtIcon.Foreground = Brushes.Green;
                txtIcon.Text = "✓";
                break;

            case NotificationType.Error:

                MainBorder.Background =
                    new SolidColorBrush(
                        (Color)ColorConverter.ConvertFromString("#FEF2F2"));

                MainBorder.BorderBrush =
                    new SolidColorBrush(
                        (Color)ColorConverter.ConvertFromString("#FCA5A5"));

                txtIcon.Foreground = Brushes.Red;
                txtIcon.Text = "✕";
                break;

            case NotificationType.Warning:

                MainBorder.Background =
                    new SolidColorBrush(
                        (Color)ColorConverter.ConvertFromString("#FFF7ED"));

                MainBorder.BorderBrush =
                    new SolidColorBrush(
                        (Color)ColorConverter.ConvertFromString("#FDBA74"));

                txtIcon.Foreground = Brushes.DarkOrange;
                txtIcon.Text = "⚠";
                break;

            case NotificationType.Info:

                MainBorder.Background =
                    new SolidColorBrush(
                        (Color)ColorConverter.ConvertFromString("#EFF6FF"));

                MainBorder.BorderBrush =
                    new SolidColorBrush(
                        (Color)ColorConverter.ConvertFromString("#93C5FD"));

                txtIcon.Foreground = Brushes.DodgerBlue;
                txtIcon.Text = "ℹ";
                break;
        }

        Visibility = Visibility.Visible;

        await Task.Delay(3000);

        Visibility = Visibility.Collapsed;
    }

    private void btnClose_Click(
        object sender,
        RoutedEventArgs e)
    {
        Visibility = Visibility.Collapsed;
    }
}
