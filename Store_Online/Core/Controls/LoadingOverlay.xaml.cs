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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Store_Online.Core.Controls
{
    /// <summary>
    /// Interaction logic for LoadingOverlay.xaml
    /// </summary>
    public partial class LoadingOverlay : UserControl
    {
        public LoadingOverlay()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty IsLoadingProperty =
            DependencyProperty.Register(
                nameof(IsLoading),
                typeof(bool),
                typeof(LoadingOverlay),
                new PropertyMetadata(false, OnLoadingChanged));

        public bool IsLoading
        {
            get => (bool)GetValue(IsLoadingProperty);
            set => SetValue(IsLoadingProperty, value);
        }

        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register(
                nameof(Message),
                typeof(string),
                typeof(LoadingOverlay),
                new PropertyMetadata("Loading..."));

        public string Message
        {
            get => (string)GetValue(MessageProperty);
            set => SetValue(MessageProperty, value);
        }

        public Visibility OverlayVisibility
        {
            get => (Visibility)GetValue(OverlayVisibilityProperty);
            set => SetValue(OverlayVisibilityProperty, value);
        }

        public static readonly DependencyProperty OverlayVisibilityProperty =
            DependencyProperty.Register(
                nameof(OverlayVisibility),
                typeof(Visibility),
                typeof(LoadingOverlay),
                new PropertyMetadata(Visibility.Collapsed));

        private static void OnLoadingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (LoadingOverlay)d;

            control.OverlayVisibility = control.IsLoading
                ? Visibility.Visible
                : Visibility.Collapsed;
        }
    }
}
