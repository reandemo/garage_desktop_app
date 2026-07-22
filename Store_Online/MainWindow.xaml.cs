using System.Windows;
using Store_Online.Views;

namespace Store_Online
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            frame.Navigate(new DashboardPage());
        }
        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            btnAdmin.ContextMenu.IsOpen = true;
        }
    }
}
