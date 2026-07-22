namespace Store_Online.Shared.Notifications;
public static class NotificationService
{
    public static void Success(
        string message)
    {
        NotificationManager.Show(
            new NotificationWindow(
                "Success",
                message,
                NotificationType.Success));
    }

    public static void Error(
        string message)
    {
        NotificationManager.Show(
            new NotificationWindow(
                "Error",
                message,
                NotificationType.Error));
    }

    public static void Warning(
        string message)
    {
        NotificationManager.Show(
            new NotificationWindow(
                "Warning",
                message,
                NotificationType.Warning));
    }

    public static void Info(
        string message)
    {
        NotificationManager.Show(
            new NotificationWindow(
                "Information",
                message,
                NotificationType.Info));
    }
}
