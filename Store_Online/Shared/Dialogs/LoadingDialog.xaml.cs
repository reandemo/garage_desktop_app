using System.Windows;
using System.Windows.Controls;

namespace Store_Online.Shared.Dialogs
{
    public partial class LoadingDialog : UserControl
    {
        public LoadingDialog()
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

        public Visibility DialogVisibility
        {
            get => Visibility;
            set => Visibility = value;
        }

        public void Show(string? message = null)
        {
            if (!string.IsNullOrWhiteSpace(message))
                Message = message;

            Visibility = Visibility.Visible;
        }

        public void Hide()
        {
            Visibility = Visibility.Collapsed;
        }

        public void UpdateMessage(string message)
        {
            Message = message;
        }

        public void Reset()
        {
            Title = "Loading";
            Message = "Please wait while we process your request...";
        }
    }
}
