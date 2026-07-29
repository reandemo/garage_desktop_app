using System.Windows;
using Store_Online.Shared.Dialogs;

namespace Store_Online.Shared.Services
{
    public static class DialogService
    {
        private static Window? _loadingWindow;
        private static LoadingDialog? _loadingDialog;

        public static void Information(
            string message,
            string title = "Store Online")
        {
            MessageBox.Show(
                message,
                title,
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        public static void Warning(
            string message,
            string title = "Store Online")
        {
            MessageBox.Show(
                message,
                title,
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
        }

        public static void Error(
            string message,
            string title = "Store Online")
        {
            MessageBox.Show(
                message,
                title,
                MessageBoxButton.OK,
                MessageBoxImage.Error);
        }

        public static void Error(
            Exception exception,
            string title = "Store Online")
        {
            if (exception == null)
                return;

            MessageBox.Show(
                exception.Message,
                title,
                MessageBoxButton.OK,
                MessageBoxImage.Error);
        }

        public static bool Confirm(
            string message,
            string title = "Store Online")
        {
            return MessageBox.Show(
                message,
                title,
                MessageBoxButton.YesNo,
                MessageBoxImage.Question)
                == MessageBoxResult.Yes;
        }

        public static MessageBoxResult ConfirmCancel(
            string message,
            string title = "Store Online")
        {
            return MessageBox.Show(
                message,
                title,
                MessageBoxButton.YesNoCancel,
                MessageBoxImage.Question);
        }

        public static MessageBoxResult Show(
            string message,
            string title,
            MessageBoxButton buttons,
            MessageBoxImage icon)
        {
            return MessageBox.Show(
                message,
                title,
                buttons,
                icon);
        }

        public static bool ShowAlert(
            string title,
            string message)
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

        public static bool ShowConfirm(
            string title,
            string message)
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

        public static string? ShowInput(
            string title,
            string message)
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

        public static string? ShowPassword(
            string title,
            string message)
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

        public static void ShowLoading(
            string title = "Loading",
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

        public static void UpdateLoading(
            string message)
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

        public static ProgressDialog CreateProgress(
            string title,
            string message)
        {
            return new ProgressDialog
            {
                Title = title,
                Message = message
            };
        }

        private static Window CreateWindow(
            UIElement content)
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
    }
}
