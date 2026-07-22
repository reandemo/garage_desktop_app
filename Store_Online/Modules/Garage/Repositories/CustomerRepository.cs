using Microsoft.Data.SqlClient;
using Store_Online.Core.Database;
using Store_Online.Core.Logging;
using Store_Online.Modules.Garage.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace Store_Online.Modules.Garage.Repositories
{
    public class CustomerRepository
    {
        private readonly SqlExecutor _sql;

        public CustomerRepository(SqlExecutor sql)
        {
            _sql = sql;
        }

        #region Get All


        public List<CustomerModel> GetAll()
        {
            try
            {
                const string sql = @"
SELECT
    CustomerId,
    Code,
    Name,
    Phone
FROM Customer
ORDER BY CustomerId DESC";

                DataTable dt = _sql.Query(sql);

                List<CustomerModel> customers = new();

                foreach (DataRow row in dt.Rows)
                {
                    customers.Add(new CustomerModel
                    {
                        CustomerId = Convert.ToInt32(row["CustomerId"]),
                        Code = row["Code"]?.ToString() ?? "",
                        Name = row["Name"]?.ToString() ?? "",
                        Phone = row["Phone"]?.ToString() ?? ""
                    });
                }

                return customers;
            }
            catch (Exception ex)
            {
                FileLogger.Log("Customer", ex);

                throw;
            }
        }

        #endregion

        #region Insert

        public bool Insert(CustomerModel model)
        {
            try
            {
                const string sql = @"
INSERT INTO Customer
(
    Code,
    Name,
    Phone
)
VALUES
(
    @Code,
    @Name,
    @Phone
)";

                int result = _sql.Execute(
                    sql,
                    CommandType.Text,

                    SqlExecutor.Parameter(
                        "@Code",
                        model.Code,
                        SqlDbType.NVarChar),

                    SqlExecutor.Parameter(
                        "@Name",
                        model.Name,
                        SqlDbType.NVarChar),

                    SqlExecutor.Parameter(
                        "@Phone",
                        model.Phone,
                        SqlDbType.NVarChar));

                return result > 0;
            }
            catch (Exception ex)
            {
                FileLogger.Log("Customer", ex);

                throw;
            }
        }

        #endregion

        #region Update

        public bool Update(CustomerModel model)
        {
            try
            {
                const string sql = @"
UPDATE Customer
SET
    Code = @Code,
    Name = @Name,
    Phone = @Phone
WHERE CustomerId = @CustomerId";

                int result = _sql.Execute(
                    sql,
                    CommandType.Text,

                    SqlExecutor.Parameter(
                        "@CustomerId",
                        model.CustomerId,
                        SqlDbType.Int),

                    SqlExecutor.Parameter(
                        "@Code",
                        model.Code,
                        SqlDbType.NVarChar),

                    SqlExecutor.Parameter(
                        "@Name",
                        model.Name,
                        SqlDbType.NVarChar),

                    SqlExecutor.Parameter(
                        "@Phone",
                        model.Phone,
                        SqlDbType.NVarChar));

                return result > 0;
            }
            catch (Exception ex)
            {
                FileLogger.Log("Customer", ex);

                throw;
            }
        }

        #endregion

        #region Delete

        public bool Delete(int customerId)
        {
            try
            {
                const string sql = @"
DELETE
FROM Customer
WHERE CustomerId=@CustomerId";

                int result = _sql.Execute(
                    sql,
                    CommandType.Text,

                    SqlExecutor.Parameter(
                        "@CustomerId",
                        customerId,
                        SqlDbType.Int));

                return result > 0;
            }
            catch (Exception ex)
            {
                FileLogger.Log("Customer", ex);

                throw;
            }
        }

        #endregion

        #region Get By Id

        public CustomerModel? GetById(int customerId)
        {
            try
            {
                const string sql = @"
SELECT
    CustomerId,
    Code,
    Name,
    Phone
FROM Customer
WHERE CustomerId=@CustomerId";

                DataTable dt = _sql.Query(
                    sql,
                    CommandType.Text,

                    SqlExecutor.Parameter(
                        "@CustomerId",
                        customerId,
                        SqlDbType.Int));

                if (dt.Rows.Count == 0)
                    return null;

                DataRow row = dt.Rows[0];

                return new CustomerModel
                {
                    CustomerId = Convert.ToInt32(row["CustomerId"]),
                    Code = row["Code"]?.ToString() ?? "",
                    Name = row["Name"]?.ToString() ?? "",
                    Phone = row["Phone"]?.ToString() ?? ""
                };
            }
            catch (Exception ex)
            {
                FileLogger.Log("Customer", ex);

                throw;
            }
        }

        #endregion

        #region Search

        public List<CustomerModel> Search(string keyword)
        {
            try
            {
                keyword ??= string.Empty;

                const string sql = @"
SELECT
    CustomerId,
    Code,
    Name,
    Phone
FROM Customer
WHERE
    Code LIKE '%' + @Keyword + '%'
    OR Name LIKE '%' + @Keyword + '%'
    OR Phone LIKE '%' + @Keyword + '%'
ORDER BY CustomerId DESC";

                DataTable dt = _sql.Query(
                    sql,
                    CommandType.Text,

                    SqlExecutor.Parameter(
                        "@Keyword",
                        keyword,
                        SqlDbType.NVarChar));

                List<CustomerModel> customers = new();

                foreach (DataRow row in dt.Rows)
                {
                    customers.Add(new CustomerModel
                    {
                        CustomerId = Convert.ToInt32(row["CustomerId"]),
                        Code = row["Code"]?.ToString() ?? string.Empty,
                        Name = row["Name"]?.ToString() ?? string.Empty,
                        Phone = row["Phone"]?.ToString() ?? string.Empty
                    });
                }

                return customers;
            }
            catch (Exception ex)
            {
                FileLogger.Log(
                    "CustomerRepository.Search",
                    ex);

                throw;
            }
        }

        #endregion

    }
}