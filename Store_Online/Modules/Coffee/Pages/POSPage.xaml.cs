using System.Windows;
using System.Windows.Controls;
using Store_Online.Shared.Notifications;

namespace Store_Online.Modules.Coffee.Pages;
/// <summary>
/// Interaction logic for POSPage.xaml
/// </summary>
public partial class POSPage : Page
{
    public POSPage()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            NotificationService.Success(
            "User click " ?? "Login successful");
        }
        catch { }
    }
}
