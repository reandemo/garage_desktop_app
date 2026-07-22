using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Store_Online.Authentication;
/// <summary>
/// Interaction logic for StoreSetup.xaml
/// </summary>
public partial class StoreSetup : Window
{
    public StoreSetup()
    {
        InitializeComponent();
    }

    private void btnCreateStore_Click(object sender, RoutedEventArgs e)
    {

    }

    private void btnBack_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
    private void BtnClose_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

}
