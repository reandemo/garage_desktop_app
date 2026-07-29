using System.Data;
using Microsoft.Data.SqlClient;
using Store_Online.Core.Logging;

namespace Store_Online.Core.Database
{
    public class SqlExecutor
    {
        private readonly DbConnectionFactory _connectionFactory;

        private const int CommandTimeout = 30;

        public SqlExecutor(DbConnectionFactory connectionFactory)
        {
            ArgumentNullException.ThrowIfNull(connectionFactory);

            _connectionFactory = connectionFactory;
        }

        #region Private

        private SqlCommand CreateCommand(
            SqlConnection connection,
            string sql,
            CommandType commandType,
            SqlParameter[]? parameters)
        {
            ArgumentNullException.ThrowIfNull(connection);
            ArgumentException.ThrowIfNullOrWhiteSpace(sql);

            SqlCommand command = new(sql, connection)
            {
                CommandType = commandType,
                CommandTimeout = CommandTimeout
            };

            if (parameters is { Length: > 0 })
            {
                foreach (SqlParameter parameter in parameters)
                {
                    if (parameter is null)
                        continue;

                    command.Parameters.Add(
                        (SqlParameter)((ICloneable)parameter).Clone());
                }
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
                    nameof(Query),
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
                    nameof(QueryDataSet),
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
                    nameof(Execute),
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

                object? result = command.ExecuteScalar();

                if (result is null || result == DBNull.Value)
                    return default;

                Type targetType =
                    Nullable.GetUnderlyingType(typeof(T))
                    ?? typeof(T);

                return (T)Convert.ChangeType(result, targetType);
            }
            catch (Exception ex)
            {
                FileLogger.Log(
                    nameof(ExecuteScalar),
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
            ArgumentException.ThrowIfNullOrWhiteSpace(procedureName);

            return Query(
                procedureName,
                CommandType.StoredProcedure,
                parameters);
        }

        public DataSet ExecuteProcedureDataSet(
            string procedureName,
            params SqlParameter[] parameters)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(procedureName);

            return QueryDataSet(
                procedureName,
                CommandType.StoredProcedure,
                parameters);
        }

        public int ExecuteProcedureNonQuery(
            string procedureName,
            params SqlParameter[] parameters)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(procedureName);

            return Execute(
                procedureName,
                CommandType.StoredProcedure,
                parameters);
        }

        public T? ExecuteProcedureScalar<T>(
            string procedureName,
            params SqlParameter[] parameters)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(procedureName);

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
            ArgumentException.ThrowIfNullOrWhiteSpace(name);

            return new SqlParameter(name, type)
            {
                Value = value ?? DBNull.Value
            };
        }

        public static SqlParameter OutputParameter(
            string name,
            SqlDbType type,
            int size = 0)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name);

            SqlParameter parameter = new(name, type)
            {
                Direction = ParameterDirection.Output
            };

            if (size > 0)
            {
                parameter.Size = size;
            }

            return parameter;
        }

        public static SqlParameter InputOutputParameter(
            string name,
            object? value,
            SqlDbType type,
            int size = 0)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name);

            SqlParameter parameter = new(name, type)
            {
                Direction = ParameterDirection.InputOutput,
                Value = value ?? DBNull.Value
            };

            if (size > 0)
            {
                parameter.Size = size;
            }

            return parameter;
        }

        #endregion
    }
}
