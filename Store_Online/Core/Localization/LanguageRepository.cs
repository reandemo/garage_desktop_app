using System.Data;
using Store_Online.Core.Database;
using Store_Online.Models;

namespace Store_Online.Core.Localization
{
    public class LanguageRepository
    {
        private readonly SqlExecutor _sqlExecutor;

        public LanguageRepository(SqlExecutor sqlExecutor)
        {
            _sqlExecutor = sqlExecutor;
        }

        private static LanguageModel Map(DataRow row)
        {
            return new LanguageModel
            {
                Id = Convert.ToInt64(row["id"]),
                LanguageCode = row["language_code"]?.ToString() ?? string.Empty,
                CultureCode = row["culture_code"]?.ToString() ?? string.Empty,
                LanguageName = row["language_name"]?.ToString() ?? string.Empty,
                NativeName = row["native_name"]?.ToString() ?? string.Empty,
                ResourceFile = row["resource_file"] == DBNull.Value
                    ? string.Empty
                    : row["resource_file"].ToString() ?? string.Empty,
                FlagIcon = row["flag_icon"] == DBNull.Value
                    ? string.Empty
                    : row["flag_icon"].ToString() ?? string.Empty,
                SortOrder = Convert.ToInt32(row["sort_order"]),
                IsDefault = Convert.ToBoolean(row["is_default"]),
                IsActive = Convert.ToBoolean(row["is_active"])
            };
        }
        public List<LanguageModel> GetLanguages()
        {
            DataTable table = _sqlExecutor.ExecuteProcedure(
                "Global_Get",
                SqlExecutor.Parameter("@CMD", "SYS_LANGUAGE", SqlDbType.NVarChar));

            List<LanguageModel> languages = new(table.Rows.Count);

            foreach (DataRow row in table.Rows)
            {
                languages.Add(Map(row));
            }

            return languages;
        }
        public LanguageModel? GetDefaultLanguage()
        {
            DataTable table = _sqlExecutor.ExecuteProcedure(
                "Global_Get",
                SqlExecutor.Parameter("@CMD", "SYS_LANGUAGE_DEFAULT", SqlDbType.NVarChar));

            if (table.Rows.Count == 0)
                return null;

            return Map(table.Rows[0]);
        }
    }
}
