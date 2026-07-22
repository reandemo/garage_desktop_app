namespace Store_Online.Core.Helpers
{
    public static class DateTimeHelper
    {
        public static string Today()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }

        public static string Now()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
