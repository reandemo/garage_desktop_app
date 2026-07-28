using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Store_Online.Shared.Dialogs
{
    public partial class ValidateInputDialog : UserControl
    {
        public ValidateInputDialog()
        {
            InitializeComponent();

            Loaded += ValidateInputDialog_Loaded;
        }

        #region Properties

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

        public string Description
        {
            get => DescriptionText.Text;
            set => DescriptionText.Text = value;
        }

        #endregion

        #region Events

        public event RoutedEventHandler? OkClicked;

        #endregion

        #region Private Methods

        private void ValidateInputDialog_Loaded(object sender, RoutedEventArgs e)
        {
            BtnOK.Focus();

            Window? window = Window.GetWindow(this);

            if (window != null)
            {
                window.KeyDown += Window_KeyDown;
            }
        }

        private void Window_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Enter:
                case Key.Escape:

                    BtnOK_Click(this, new RoutedEventArgs());
                    e.Handled = true;
                    break;
            }
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            OkClicked?.Invoke(this, e);
        }

        #endregion
    }
}
