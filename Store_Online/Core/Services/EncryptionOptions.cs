namespace Store_Online.Core.Security
{
    public sealed class EncryptionOptions
    {
        public string Password { get; set; } = string.Empty;

        public string Salt { get; set; } = string.Empty;

        public int KeySize { get; set; }

        public int Iterations { get; set; }
    }
}