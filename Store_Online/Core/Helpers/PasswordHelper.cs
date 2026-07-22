using System.Security.Cryptography;
using System.Text;

namespace Store_Online.Core.Helpers
{
    public static class PasswordHelper
    {
        public static string ComputeSha256(string text)
        {
            using SHA256 sha = SHA256.Create();

            byte[] bytes = sha.ComputeHash(
                Encoding.UTF8.GetBytes(text));

            return Convert.ToHexString(bytes);
        }

        public static bool Verify(string password, string hash)
        {
            return ComputeSha256(password) == hash;
        }
    }
}
