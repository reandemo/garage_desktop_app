namespace Store_Online.Shared.Helpers
{
    public static class FlagHelper
    {
        private const string BasePath =
            "pack://application:,,,/Shared/Assets/Flags/";

        public const string US = BasePath + "us.png";
        public const string KH = BasePath + "kh.png";
        public const string CN = BasePath + "cn.png";

        // Add jp.png to Shared/Assets/Flags before using this.
        public const string JP = BasePath + "jp.png";
    }
}
