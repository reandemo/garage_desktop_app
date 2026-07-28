using System.Windows;
using System.Windows.Controls;

namespace Store_Online.Shared.Controls
{
    public partial class GarageLoading : UserControl
    {
        public GarageLoading()
        {
            InitializeComponent();
        }

        #region Message

        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register(
                nameof(Message),
                typeof(string),
                typeof(GarageLoading),
                new PropertyMetadata("Loading... Please wait."));

        public string Message
        {
            get => (string)GetValue(MessageProperty);
            set => SetValue(MessageProperty, value);
        }

        #endregion
    }
}