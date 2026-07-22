using System.Windows;
using System.Windows.Controls;

namespace Store_Online.Modules.Coffee.Pages;

public partial class ProductPage : Page
{
    public ProductPage()
    {
        InitializeComponent();
    }

    private void BtnNew_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show(
            "Open Product Form",
            "Rean POS",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
    }

    private void BtnSave_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show(
            "Product saved successfully.",
            "Rean POS",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
    }

    private void BtnRefresh_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show(
            "Data refreshed.",
            "Rean POS",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
    }

    private void BtnDelete_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show(
            "Delete selected product?",
            "Rean POS",
            MessageBoxButton.YesNo,
            MessageBoxImage.Question);
    }
}
