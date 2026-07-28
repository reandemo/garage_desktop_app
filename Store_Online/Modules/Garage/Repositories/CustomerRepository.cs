using System.Data;
using Store_Online.Core.Database;
using Store_Online.Modules.Garage.Models;

namespace Store_Online.Modules.Garage.Repositories
{
    public class CustomerRepository
    {
        private readonly SqlExecutor _sqlExecutor;

        public CustomerRepository(SqlExecutor sqlExecutor)
        {
            ArgumentNullException.ThrowIfNull(sqlExecutor);

            _sqlExecutor = sqlExecutor;
        }

        public string Save(CustomerModel model)
        {
            ArgumentNullException.ThrowIfNull(model);

            DataTable table =
                _sqlExecutor.ExecuteProcedure(
                    "garage_customer_save",

                    SqlExecutor.Parameter("@CMD", model.Command, SqlDbType.NVarChar),
                    SqlExecutor.Parameter("@BranchCode", model.BranchCode, SqlDbType.NVarChar),
                    SqlExecutor.Parameter("@CustomerID", model.CustomerId, SqlDbType.NVarChar),
                    SqlExecutor.Parameter("@CustomerName", model.CustomerName, SqlDbType.NVarChar),
                    SqlExecutor.Parameter("@Gender", (object?)model.Gender ?? DBNull.Value, SqlDbType.NVarChar),
                    SqlExecutor.Parameter("@DOB", (object?)model.DateOfBirth ?? DBNull.Value, SqlDbType.Date),
                    SqlExecutor.Parameter("@Phone", (object?)model.Phone ?? DBNull.Value, SqlDbType.NVarChar),
                    SqlExecutor.Parameter("@Email", (object?)model.Email ?? DBNull.Value, SqlDbType.NVarChar),
                    SqlExecutor.Parameter("@Remark", (object?)model.Remark ?? DBNull.Value, SqlDbType.NVarChar),
                    SqlExecutor.Parameter("@CreatedBy", model.CreatedBy, SqlDbType.NVarChar));

            if (table == null || table.Rows.Count == 0)
                return string.Empty;

            return table.Rows[0]["CustomerID"]?.ToString() ?? string.Empty;
        }
    }
}
