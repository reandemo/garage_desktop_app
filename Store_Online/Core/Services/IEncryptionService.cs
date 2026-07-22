namespace Store_Online.Core.Security
{
    public interface IEncryptionService
    {
        /// <summary>
        /// Encrypt plain text and return a Base64 string.
        /// </summary>
        /// <param name="plainText">Text to encrypt.</param>
        /// <returns>Encrypted Base64 string.</returns>
        string Encrypt(string plainText);

        /// <summary>
        /// Decrypt a Base64 encrypted string.
        /// </summary>
        /// <param name="encryptedText">Encrypted Base64 string.</param>
        /// <returns>Original plain text.</returns>
        string Decrypt(string encryptedText);

        /// <summary>
        /// Determines whether the specified string is encrypted.
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <returns>True if the value can be decrypted; otherwise, false.</returns>
        bool IsEncrypted(string value);

        /// <summary>
        /// Encrypt the value only if it is not already encrypted.
        /// </summary>
        /// <param name="value">Plain or encrypted value.</param>
        /// <returns>Encrypted Base64 string.</returns>
        string EncryptIfNeeded(string value);
    }
}