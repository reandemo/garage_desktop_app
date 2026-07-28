using System.Windows;
using System.Windows.Controls;

namespace Store_Online.Shared.Controls
{
    public partial class GarageBreadcrumb : UserControl
    {
        public GarageBreadcrumb()
        {
            InitializeComponent();
        }

        #region HomeText

        public static readonly DependencyProperty HomeTextProperty =
            DependencyProperty.Register(
                nameof(HomeText),
                typeof(string),
                typeof(GarageBreadcrumb),
                new PropertyMetadata("Home"));

        public string HomeText
        {
            get => (string)GetValue(HomeTextProperty);
            set => SetValue(HomeTextProperty, value);
        }

        #endregion

        #region ModuleText

        public static readonly DependencyProperty ModuleTextProperty =
            DependencyProperty.Register(
                nameof(ModuleText),
                typeof(string),
                typeof(GarageBreadcrumb),
                new PropertyMetadata("Module"));

        public string ModuleText
        {
            get => (string)GetValue(ModuleTextProperty);
            set => SetValue(ModuleTextProperty, value);
        }

        #endregion

        #region PageText

        public static readonly DependencyProperty PageTextProperty =
            DependencyProperty.Register(
                nameof(PageText),
                typeof(string),
                typeof(GarageBreadcrumb),
                new PropertyMetadata("Page"));

        public string PageText
        {
            get => (string)GetValue(PageTextProperty);
            set => SetValue(PageTextProperty, value);
        }

        #endregion
    }
}