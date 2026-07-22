using Store_Online.Core.Logging;
using Store_Online.Core.Security;
using System.IO;
using System.Windows;
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
                throw new FileNotFoundException(file);

            XDocument xml = XDocument.Load(file);

            string vUser = _encryption.Encrypt("sa");

            FileLogger.Log(
                "Configuration " + xml.Root!.Element("Database")?.Value ?? "",
                "Database configuration loaded successfully from sys.xml.");


            return new DatabaseSettings
            {
                Server = xml.Root!.Element("Server")?.Value ?? "",

                Database = xml.Root.Element("Database")?.Value ?? "",

                User = _encryption.Decrypt(
                    xml.Root.Element("User")?.Value ?? ""),

                Password = _encryption.Decrypt(
                    xml.Root.Element("Password")?.Value ?? "")
            };
        }
        catch (Exception ex)
        {
            FileLogger.Log(
                "XmlDatabaseReader.Load",
                ex);

            throw;
        }
    }
}