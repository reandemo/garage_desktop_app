using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Online.Core.Helpers
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
