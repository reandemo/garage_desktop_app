using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Store_Online.Core.Database
{
    public sealed class DbConnectionFactory
    {
        private readonly string _connectionString;

        public DbConnectionFactory(string connectionString)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(connectionString);

            _connectionString = connectionString;
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public SqlConnection CreateOpenConnection()
        {
            SqlConnection connection = CreateConnection();

            if (connection.State != ConnectionState.Open)
                connection.Open();

            return connection;
        }
    }
}