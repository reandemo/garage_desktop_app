using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Store_Online.Shared.UI.Controls;

namespace Store_Online.Modules.Coffee.Pages
{
    public partial class OrderPage : Page
    {
        public OrderPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is ReanButton button)
            {
                txtResult.Text =
                    $"[{DateTime.Now:HH:mm:ss}] You clicked '{button.Text}' button.";

                MessageBox.Show(
                    $"You clicked : {button.Text}",
                    "ReanButton Test",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
        }

        private async void BtnBusy_Click(object sender, RoutedEventArgs e)
        {
            btnBusy.IsBusy = true;

            txtResult.Text = "Saving order...";

            await Task.Delay(3000);

            btnBusy.IsBusy = false;

            txtResult.Text =
                $"[{DateTime.Now:HH:mm:ss}] Order saved successfully.";

            MessageBox.Show(
                "Order saved successfully.",
                "Rean POS",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
    }
}
