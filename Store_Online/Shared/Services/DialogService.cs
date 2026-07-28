using System.Windows;
using Store_Online.Shared.Dialogs;

namespace Store_Online.Shared.Services
{
    public static class DialogService
    {
        private static Window? _loadingWindow;
        private static LoadingDialog? _loadingDialog;

        #region Alert

        public static bool ShowAlert(string title, string message)
        {
            var dialog = new AlertDialog
            {
                Title = title,
                Message = message
            };

            var window = CreateWindow(dialog);

            dialog.OkClicked += (_, _) =>
            {
                window.DialogResult = true;
                window.Close();
            };

            return window.ShowDialog() == true;
        }

        #endregion

        #region Confirm

        public static bool ShowConfirm(string title, string message)
        {
            bool result = false;

            var dialog = new ConfirmDialog
            {
                Title = title,
                Message = message
            };

            var window = CreateWindow(dialog);

            dialog.OkClicked += (_, _) =>
            {
                result = true;
                window.DialogResult = true;
                window.Close();
            };

            dialog.CancelClicked += (_, _) =>
            {
                result = false;
                window.DialogResult = false;
                window.Close();
            };

            window.ShowDialog();

            return result;
        }

        #endregion

        #region Input

        public static string? ShowInput(string title, string message)
        {
            string? value = null;

            var dialog = new InputDialog
            {
                Title = title,
                Message = message
            };

            var window = CreateWindow(dialog);

            dialog.OkClicked += (_, _) =>
            {
                value = dialog.InputText;
                window.DialogResult = true;
                window.Close();
            };

            dialog.CancelClicked += (_, _) =>
            {
                window.DialogResult = false;
                window.Close();
            };

            window.ShowDialog();

            return value;
        }

        #endregion

        #region Password

        public static string? ShowPassword(string title, string message)
        {
            string? password = null;

            var dialog = new PasswordDialog
            {
                Title = title,
                Message = message
            };

            var window = CreateWindow(dialog);

            dialog.OkClicked += (_, _) =>
            {
                password = dialog.Password;
                window.DialogResult = true;
                window.Close();
            };

            dialog.CancelClicked += (_, _) =>
            {
                window.DialogResult = false;
                window.Close();
            };

            window.ShowDialog();

            return password;
        }

        #endregion

        #region Loading

        public static void ShowLoading(string title = "Loading",
                                       string message = "Please wait...")
        {
            if (_loadingWindow != null)
                return;

            _loadingDialog = new LoadingDialog
            {
                Title = title,
                Message = message
            };

            _loadingWindow = CreateWindow(_loadingDialog);

            _loadingWindow.Show();
        }

        public static void UpdateLoading(string message)
        {
            if (_loadingDialog != null)
                _loadingDialog.Message = message;
        }

        public static void CloseLoading()
        {
            if (_loadingWindow == null)
                return;

            _loadingWindow.Close();

            _loadingWindow = null;
            _loadingDialog = null;
        }

        #endregion

        #region Progress

        public static ProgressDialog CreateProgress(string title,
                                                    string message)
        {
            return new ProgressDialog
            {
                Title = title,
                Message = message
            };
        }

        #endregion

        #region Window

        private static Window CreateWindow(UIElement content)
        {
            return new Window
            {
                Content = content,
                SizeToContent = SizeToContent.WidthAndHeight,
                ResizeMode = ResizeMode.NoResize,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                WindowStyle = WindowStyle.None,
                AllowsTransparency = true,
                Background = null,
                ShowInTaskbar = false
            };
        }

        #endregion
    }
}
