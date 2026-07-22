using System.Windows;

namespace Store_Online.Shared.Notifications
{
    public static class NotificationManager
    {
        private static readonly List<NotificationWindow>
            Notifications = new();

        public static void Show(
            NotificationWindow window)
        {
            Notifications.Add(window);

            window.Closed += (s, e) =>
            {
                Notifications.Remove(window);
                Reposition();
            };

            window.Show();

            Reposition();
        }

        private static void Reposition()
        {
            double rightMargin = 15;
            double bottomMargin = 15;
            double spacing = 10;

            for (int i = 0; i < Notifications.Count; i++)
            {
                var win = Notifications[i];

                win.Left =
                    SystemParameters.WorkArea.Width -
                    win.Width -
                    rightMargin;

                win.Top =
                    SystemParameters.WorkArea.Height -
                    win.Height -
                    bottomMargin -
                    (Notifications.Count - 1 - i)
                    * (win.Height + spacing);
            }
        }
    }
}
