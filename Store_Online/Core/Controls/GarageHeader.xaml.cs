using Store_Online.Core.Helpers;
using Store_Online.Core.Localization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Store_Online.Core.Controls
{
    /// <summary>
    /// Interaction logic for GarageHeader.xaml
    /// </summary>
    public partial class GarageHeader : UserControl
    {
        public GarageHeader()
        {
            InitializeComponent();

            Loaded += GarageHeader_Loaded;
        }

        private void GarageHeader_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCurrentLanguage();
        }

        private void LoadCurrentLanguage()
        {
            try
            {
                string language;
                string flag;

                switch (LanguageManager.CurrentCulture.Name)
                {
                    case "km-KH":
                        language = "Khmer";
                        flag = FlagHelper.KH;
                        break;

                    case "zh-CN":
                        language = "Chinese";
                        flag = FlagHelper.CN;
                        break;

                    case "ja-JP":
                        language = "Japanese";
                        flag = FlagHelper.JP;
                        break;

                    default:
                        language = "English";
                        flag = FlagHelper.US;
                        break;
                }

                txtCurrentLanguage.Text = language;

                imgCurrentLanguage.Source = new BitmapImage(
                    new Uri(flag, UriKind.RelativeOrAbsolute));
            }
            catch
            {
                txtCurrentLanguage.Text = "English";
                imgCurrentLanguage.Source = null;
            }
        }

        private void Chinese_Click(object sender, RoutedEventArgs e)
        {
            LanguageManager.ChangeCulture("zh-CN");
            LoadCurrentLanguage();
        }

        private void English_Click(object sender, RoutedEventArgs e)
        {
            LanguageManager.ChangeCulture("en-US");
            LoadCurrentLanguage();
        }

        private void Khmer_Click(object sender, RoutedEventArgs e)
        {
            LanguageManager.ChangeCulture("km-KH");
            LoadCurrentLanguage();
        }
    }
}
