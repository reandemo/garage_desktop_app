namespace Store_Online.Core.Interfaces
{
    public interface INotificationService
    {
        void ShowSuccess(string message);

        void ShowInfo(string message);

        void ShowWarning(string message);

        void ShowError(string message);
    }
}
