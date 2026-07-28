using System.Windows;
using System.Windows.Controls;

namespace Store_Online.Shared.Dialogs
{
    public partial class ProgressDialog : UserControl
    {
        public ProgressDialog()
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

        public double Progress
        {
            get => ProgressBar.Value;
            set
            {
                double progress = value;

                if (progress < ProgressBar.Minimum)
                    progress = ProgressBar.Minimum;

                if (progress > ProgressBar.Maximum)
                    progress = ProgressBar.Maximum;

                ProgressBar.Value = progress;
                PercentText.Text = $"{progress:0}%";
            }
        }

        public bool IsIndeterminate
        {
            get => ProgressBar.IsIndeterminate;
            set
            {
                ProgressBar.IsIndeterminate = value;

                PercentText.Visibility = value
                    ? Visibility.Collapsed
                    : Visibility.Visible;
            }
        }

        public event RoutedEventHandler? CancelClicked;

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            CancelClicked?.Invoke(this, e);
        }

        public void Reset()
        {
            Progress = 0;
            IsIndeterminate = false;
        }

        public void Complete()
        {
            Progress = 100;
        }

        public void SetProgress(double value, string? message = null)
        {
            Progress = value;

            if (!string.IsNullOrWhiteSpace(message))
                Message = message;
        }
    }
}
