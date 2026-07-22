using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Store_Online.Core.Helpers;
using Store_Online.Core.Localization;
using Store_Online.Modules.Coffee.Pages;
namespace Store_Online.MainForms
{
    public partial class CoffeeMainWindow : Window
    {
        public CoffeeMainWindow()
        {
            InitializeComponent();

            LoadCurrentLanguage();


            lblUser.Text = "Administrator";
            lblBranch.Text = "Main Branch";
            lblVersion.Text = "Version 1.0.0";

            MainFrame.Navigate(new CoffeeDashboard());
        }

        private void LoadCurrentLanguage()
        {
            switch (LanguageManager.CurrentCulture.Name)
            {
                case "km-KH":
                    txtCurrentLanguage.Text = "Khmer";
                    imgCurrentLanguage.Source =
                        new BitmapImage(new Uri(FlagHelper.KH, UriKind.Absolute));
                    break;

                case "zh-CN":
                    txtCurrentLanguage.Text = "Chinese";
                    imgCurrentLanguage.Source =
                        new BitmapImage(new Uri(FlagHelper.CN, UriKind.Absolute));
                    break;



                default:
                    txtCurrentLanguage.Text = "English";
                    imgCurrentLanguage.Source =
                        new BitmapImage(new Uri(FlagHelper.US, UriKind.Absolute));
                    break;
            }
        }


        private void BtnDashboard_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CoffeeDashboard());
        }

        private void BtnPOS_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new OrderPage());
        }

        private void BtnProduct_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductPage());
        }

        private void BtnReport_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductPage());
        }

        private void BtnUser_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductPage());
        }

        private void BtnSystemSetting_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductPage());
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("My Profile");
        }

        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Change Password");
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductPage());
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {

        }


        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            BtnBack.IsEnabled = MainFrame.CanGoBack;
        }

        private void English_Click(object sender, RoutedEventArgs e)
        {
            LanguageManager.ChangeCulture("en-US");
            txtCurrentLanguage.Text = "English";

            imgCurrentLanguage.Source =
                new BitmapImage(new Uri(FlagHelper.US, UriKind.Absolute));
        }

        private void Chinese_Click(object sender, RoutedEventArgs e)
        {
            LanguageManager.ChangeCulture("zh-CN");

            txtCurrentLanguage.Text = "Chinese";

            imgCurrentLanguage.Source =
                new BitmapImage(new Uri(FlagHelper.CN, UriKind.Absolute));
        }

        private void Khmer_Click(object sender, RoutedEventArgs e)
        {
            LanguageManager.ChangeCulture("km-KH");
            txtCurrentLanguage.Text = "Khmer";

            imgCurrentLanguage.Source =
                new BitmapImage(new Uri(FlagHelper.KH, UriKind.Absolute));
        }


    }
}
