using Microsoft.Data.SqlClient;
using Store_Online.Core.Logging;
using System;
using System.Data;

namespace Store_Online.Core.Database
{
    public class SqlExecutor
    {
        private readonly DbConnectionFactory _connectionFactory;

        // Default SQL timeout (seconds)
        private const int CommandTimeout = 30;

        public SqlExecutor(DbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        #region Private

        private SqlCommand CreateCommand(
            SqlConnection connection,
            string sql,
            CommandType commandType,
            SqlParameter[]? parameters)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(sql);

            SqlCommand command = new(sql, connection)
            {
                CommandType = commandType,
                CommandTimeout = CommandTimeout
            };

            if (parameters is { Length: > 0 })
            {
                command.Parameters.AddRange(parameters);
            }

            return command;
        }

        #endregion

        #region Query

        public DataTable Query(
            string sql,
            CommandType commandType = CommandType.Text,
            params SqlParameter[] parameters)
        {
            try
            {
                using SqlConnection connection =
                    _connectionFactory.CreateOpenConnection();

                using SqlCommand command =
                    CreateCommand(connection, sql, commandType, parameters);

                using SqlDataReader reader =
                    command.ExecuteReader();

                DataTable table = new();

                table.Load(reader);

                return table;
            }
            catch (Exception ex)
            {
                FileLogger.Log(
                    "SqlExecutor.Query",
                    ex,
                    sql,
                    parameters);

                throw;
            }
        }

        #endregion

        #region DataSet

        public DataSet QueryDataSet(
            string sql,
            CommandType commandType = CommandType.Text,
            params SqlParameter[] parameters)
        {
            try
            {
                using SqlConnection connection =
                    _connectionFactory.CreateOpenConnection();

                using SqlCommand command =
                    CreateCommand(connection, sql, commandType, parameters);

                using SqlDataAdapter adapter =
                    new(command);

                DataSet dataSet = new();

                adapter.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                FileLogger.Log(
                    "SqlExecutor.QueryDataSet",
                    ex,
                    sql,
                    parameters);

                throw;
            }
        }

        #endregion

        #region Execute

        public int Execute(
            string sql,
            CommandType commandType = CommandType.Text,
            params SqlParameter[] parameters)
        {
            try
            {
                using SqlConnection connection =
                    _connectionFactory.CreateOpenConnection();

                using SqlCommand command =
                    CreateCommand(connection, sql, commandType, parameters);

                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                FileLogger.Log(
                    "SqlExecutor.Execute",
                    ex,
                    sql,
                    parameters);

                throw;
            }
        }

        #endregion

        #region Scalar

        public T? ExecuteScalar<T>(
            string sql,
            CommandType commandType = CommandType.Text,
            params SqlParameter[] parameters)
        {
            try
            {
                using SqlConnection connection =
                    _connectionFactory.CreateOpenConnection();

                using SqlCommand command =
                    CreateCommand(connection, sql, commandType, parameters);

                object? result =
                    command.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                    return default;

                return (T)Convert.ChangeType(
                    result,
                    typeof(T));
            }
            catch (Exception ex)
            {
                FileLogger.Log(
                    "SqlExecutor.ExecuteScalar",
                    ex,
                    sql,
                    parameters);

                throw;
            }
        }

        #endregion

        #region Stored Procedure

        public DataTable ExecuteProcedure(
            string procedureName,
            params SqlParameter[] parameters)
        {
            return Query(
                procedureName,
                CommandType.StoredProcedure,
                parameters);
        }

        public DataSet ExecuteProcedureDataSet(
            string procedureName,
            params SqlParameter[] parameters)
        {
            return QueryDataSet(
                procedureName,
                CommandType.StoredProcedure,
                parameters);
        }

        public int ExecuteProcedureNonQuery(
            string procedureName,
            params SqlParameter[] parameters)
        {
            return Execute(
                procedureName,
                CommandType.StoredProcedure,
                parameters);
        }

        public T? ExecuteProcedureScalar<T>(
            string procedureName,
            params SqlParameter[] parameters)
        {
            return ExecuteScalar<T>(
                procedureName,
                CommandType.StoredProcedure,
                parameters);
        }

        #endregion

        #region Parameter Helper

        public static SqlParameter Parameter(
            string name,
            object? value,
            SqlDbType type)
        {
            return new SqlParameter(name, type)
            {
                Value = value ?? DBNull.Value
            };
        }

        #endregion
    }
}