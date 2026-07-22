using System;
using System.Windows;

namespace Store_Online.Core.Services
{
    /// <summary>
    /// Centralized dialog service for the application.
    /// </summary>
    public static class DialogService
    {
        /// <summary>
        /// Show information dialog.
        /// </summary>
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

        /// <summary>
        /// Show warning dialog.
        /// </summary>
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

        /// <summary>
        /// Show error dialog.
        /// </summary>
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

        /// <summary>
        /// Show exception dialog.
        /// </summary>
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

        /// <summary>
        /// Show confirmation dialog.
        /// </summary>
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

        /// <summary>
        /// Show Yes / No / Cancel dialog.
        /// </summary>
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

        /// <summary>
        /// Show custom dialog.
        /// </summary>
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
    }
}