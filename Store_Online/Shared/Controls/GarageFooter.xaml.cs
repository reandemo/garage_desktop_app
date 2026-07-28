using System.Windows;
using System.Windows.Controls;

namespace Store_Online.Shared.Controls
{
    public partial class GarageFooter : UserControl
    {
        public GarageFooter()
        {
            InitializeComponent();
        }

        #region Copyright

        public static readonly DependencyProperty CopyrightProperty =
            DependencyProperty.Register(
                nameof(Copyright),
                typeof(string),
                typeof(GarageFooter),
                new PropertyMetadata("© 2026 Garage Management System. All rights reserved."));

        public string Copyright
        {
            get => (string)GetValue(CopyrightProperty);
            set => SetValue(CopyrightProperty, value);
        }

        #endregion

        #region Version

        public static readonly DependencyProperty VersionProperty =
            DependencyProperty.Register(
                nameof(Version),
                typeof(string),
                typeof(GarageFooter),
                new PropertyMetadata("Version 1.0.0"));

        public string Version
        {
            get => (string)GetValue(VersionProperty);
            set => SetValue(VersionProperty, value);
        }

        #endregion

        #region CurrentUser

        public static readonly DependencyProperty CurrentUserProperty =
            DependencyProperty.Register(
                nameof(CurrentUser),
                typeof(string),
                typeof(GarageFooter),
                new PropertyMetadata("Guest"));

        public string CurrentUser
        {
            get => (string)GetValue(CurrentUserProperty);
            set => SetValue(CurrentUserProperty, value);
        }

        #endregion
    }
}