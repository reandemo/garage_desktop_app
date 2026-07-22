using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Store_Online.Core.Security
{
    public sealed class EncryptionService : IEncryptionService
    {
        private readonly EncryptionOptions _options;

        public EncryptionService()
            : this(new EncryptionOptions())
        {
        }

        public EncryptionService(EncryptionOptions options)
        {
            _options = options;
        }

        public string Encrypt(string plainText)
        {
            if (string.IsNullOrWhiteSpace(plainText))
                return string.Empty;

            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

            using Aes aes = Aes.Create();

            aes.KeySize = _options.KeySize;
            aes.BlockSize = 128;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            using var key = new Rfc2898DeriveBytes(
                _options.Password,
                Encoding.UTF8.GetBytes(_options.Salt),
                _options.Iterations,
                HashAlgorithmName.SHA256);

            aes.Key = key.GetBytes(aes.KeySize / 8);

            // Generate a new IV every encryption
            aes.GenerateIV();

            using MemoryStream ms = new();

            // Save IV at beginning of stream
            ms.Write(aes.IV, 0, aes.IV.Length);

            using (CryptoStream cs = new(
                ms,
                aes.CreateEncryptor(),
                CryptoStreamMode.Write))
            {
                cs.Write(plainBytes, 0, plainBytes.Length);
                cs.FlushFinalBlock();
            }

            return Convert.ToBase64String(ms.ToArray());
        }

        public string Decrypt(string encryptedText)
        {
            if (string.IsNullOrWhiteSpace(encryptedText))
                return string.Empty;

            byte[] cipherBytes = Convert.FromBase64String(encryptedText);

            using MemoryStream ms = new(cipherBytes);

            using Aes aes = Aes.Create();

            aes.KeySize = _options.KeySize;
            aes.BlockSize = 128;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            using var key = new Rfc2898DeriveBytes(
                _options.Password,
                Encoding.UTF8.GetBytes(_options.Salt),
                _options.Iterations,
                HashAlgorithmName.SHA256);

            aes.Key = key.GetBytes(aes.KeySize / 8);

            // Read IV
            byte[] iv = new byte[16];
            ms.Read(iv, 0, iv.Length);

            aes.IV = iv;

            using CryptoStream cs = new(
                ms,
                aes.CreateDecryptor(),
                CryptoStreamMode.Read);

            using StreamReader sr = new(cs);

            return sr.ReadToEnd();
        }

        public bool IsEncrypted(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            try
            {
                Decrypt(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string EncryptIfNeeded(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Empty;

            return IsEncrypted(value)
                ? value
                : Encrypt(value);
        }
    }
}