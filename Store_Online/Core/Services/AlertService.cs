using System.Windows;
using Store_Online.Shared.Dialogs;

namespace Store_Online.Core.Services
{
    public static class AlertService
    {
        #region Alert

        public static void Success(string message, string title = "Success")
        {
            Show(message, title);
        }

        public static void Error(string message, string title = "Error")
        {
            Show(message, title);
        }

        public static void Warning(string message, string title = "Warning")
        {
            Show(message, title);
        }

        public static void Information(string message, string title = "Information")
        {
            Show(message, title);
        }

        #endregion

        #region Confirm

        public static bool Confirm(string message, string title = "Confirmation")
        {
            var dialog = new ConfirmDialog
            {
                Title = title,
                Message = message
            };

            bool result = false;

            Window window = CreateDialogWindow(dialog);

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

        public static string? Input(string title, string message)
        {
            var dialog = new InputDialog
            {
                Title = title,
                Message = message
            };

            string? result = null;

            Window window = CreateDialogWindow(dialog);

            dialog.OkClicked += (_, _) =>
            {
                result = dialog.InputText;
                window.DialogResult = true;
                window.Close();
            };

            dialog.CancelClicked += (_, _) =>
            {
                window.DialogResult = false;
                window.Close();
            };

            window.ShowDialog();

            return result;
        }

        #endregion

        #region Password

        public static string? Password(string title, string message)
        {
            var dialog = new PasswordDialog
            {
                Title = title,
                Message = message
            };

            string? result = null;

            Window window = CreateDialogWindow(dialog);

            dialog.OkClicked += (_, _) =>
            {
                result = dialog.Password;
                window.DialogResult = true;
                window.Close();
            };

            dialog.CancelClicked += (_, _) =>
            {
                window.DialogResult = false;
                window.Close();
            };

            window.ShowDialog();

            return result;
        }

        #endregion

        #region Validate Input

        public static void ValidateInput(
            string message,
            string title = "Validation",
            string description = "Please enter a valid value and try again.")
        {
            var dialog = new ValidateInputDialog
            {
                Title = title,
                Message = message,
                Description = description
            };

            Window window = CreateDialogWindow(dialog);

            dialog.OkClicked += (_, _) =>
            {
                window.DialogResult = true;
                window.Close();
            };

            window.ShowDialog();
        }

        #endregion

        #region Private

        private static void Show(string message, string title)
        {
            var dialog = new AlertDialog
            {
                Title = title,
                Message = message
            };

            Window window = CreateDialogWindow(dialog);

            dialog.OkClicked += (_, _) =>
            {
                window.DialogResult = true;
                window.Close();
            };

            window.ShowDialog();
        }

        private static Window CreateDialogWindow(UIElement content)
        {
            Window? owner = Application.Current.Windows
                .OfType<Window>()
                .FirstOrDefault(w => w.IsActive);

            owner ??= Application.Current?.MainWindow;

            return new Window
            {
                Owner = owner,
                Content = content,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStyle = WindowStyle.None,
                ResizeMode = ResizeMode.NoResize,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                AllowsTransparency = true,
                ShowInTaskbar = false,
                ShowActivated = true
            };
        }

        #endregion
    }
}
