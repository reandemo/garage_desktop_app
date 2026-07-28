using System.Windows;
using System.Windows.Controls;

namespace Store_Online.Shared.Dialogs
{
    public partial class InputDialog : UserControl
    {
        public InputDialog()
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

        public string InputText
        {
            get => InputTextBox.Text;
            set => InputTextBox.Text = value;
        }

        public event RoutedEventHandler? OkClicked;
        public event RoutedEventHandler? CancelClicked;

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            OkClicked?.Invoke(this, e);
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            CancelClicked?.Invoke(this, e);
        }

        public void FocusInput()
        {
            InputTextBox.Focus();
            InputTextBox.SelectAll();
        }

        public void Clear()
        {
            InputTextBox.Clear();
        }
    }
}
