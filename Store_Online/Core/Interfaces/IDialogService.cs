namespace Store_Online.Core.Interfaces
{
    public interface IDialogService
    {
        void ShowInfo(string message, string title = "Information");

        void ShowWarning(string message, string title = "Warning");

        void ShowError(string message, string title = "Error");

        bool ShowConfirmation(string message, string title = "Confirmation");
    }
}
