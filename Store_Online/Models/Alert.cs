namespace Store_Online.Models;
using HandyControl.Controls;
public static class Alert
{
    public static void Success(string message)
    {
        Growl.Success(message);
    }

    public static void Error(string message)
    {
        Growl.Error(message);
    }

    public static void Info(string message)
    {
        Growl.Info(message);
    }

    public static void Warning(string message)
    {
        Growl.Warning(message);
    }
}