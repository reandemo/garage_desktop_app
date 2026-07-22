using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
namespace Store_Online.Core.Controls
{
    public partial class GarageTopMenu : UserControl
    {
        public event EventHandler<string>? MenuClicked;

        public GarageTopMenu()
        {
            InitializeComponent();
        }

        private void ResetMenuStyle()
        {
            ResetMenuItems(Menu);
        }

        private void ResetMenuItems(ItemsControl parent)
        {
            foreach (var item in parent.Items)
            {
                if (item is not MenuItem menuItem)
                    continue;

                menuItem.Foreground = Brushes.Black;
                menuItem.FontWeight = FontWeights.Normal;

                if (menuItem.HasItems)
                {
                    ResetMenuItems(menuItem);
                }
            }
        }

        private void SelectMenu(MenuItem menuItem)
        {
            ResetMenuStyle();

            menuItem.Foreground = Brushes.Red;
            menuItem.FontWeight = FontWeights.Bold;
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            if (sender is not MenuItem menuItem)
                return;

            if (menuItem.Tag is not string tag)
                return;

            SelectMenu(menuItem);

            MenuClicked?.Invoke(this, tag);

            menuItem.IsSubmenuOpen = false;
            Keyboard.ClearFocus();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Exit",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
