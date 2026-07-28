using System.Windows;
using System.Windows.Controls;

namespace Store_Online.Shared.Dialogs
{
    public partial class AlertDialog : UserControl
    {
        public AlertDialog()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => TitleText.Text;
            set => TitleText.Text = value;
        }

        public string Message
        {
            get => MessageText.Text;
            set => MessageText.Text = value;
        }

        public event RoutedEventHandler? OkClicked;

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            OkClicked?.Invoke(this, e);
        }
    }
}
