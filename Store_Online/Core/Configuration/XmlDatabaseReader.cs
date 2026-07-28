using Store_Online.Core.Logging;
using Store_Online.Core.Security;
using System.IO;
using System.Xml.Linq;

namespace Store_Online.Core.Configuration;

public class XmlDatabaseReader
{
    private readonly IEncryptionService _encryption;

    public XmlDatabaseReader(IEncryptionService encryption)
    {
        _encryption = encryption;
    }

    public DatabaseSettings Load(string file)
    {
        try
        {
            if (!File.Exists(file))
                throw new FileNotFoundException(
                    "Configuration file not found.",
                    file);

            XDocument xml = XDocument.Load(file);

            XElement root = xml.Root
                ?? throw new InvalidDataException(
                    "Invalid configuration file.");

            DatabaseSettings settings = new()
            {
                Server = root.Element("Server")?.Value ?? string.Empty,

                Database = root.Element("Database")?.Value ?? string.Empty,

                User = _encryption.Decrypt(
                    root.Element("User")?.Value ?? string.Empty),

                Password = _encryption.Decrypt(
                    root.Element("Password")?.Value ?? string.Empty)
            };

            FileLogger.Log(
                $"Configuration ({settings.Database})",
                "Database configuration loaded successfully from sys.xml.");

            return settings;
        }
        catch (Exception ex)
        {
            FileLogger.Log(
                nameof(XmlDatabaseReader),
                ex);

            throw;
        }
    }
}