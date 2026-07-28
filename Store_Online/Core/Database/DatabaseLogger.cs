using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;
using Store_Online.Core.Database;

namespace Store_Online.Core.Logging
{
    public class DatabaseLogger
    {
        private const string Information = "Information";
        private const string WarningLevel = "Warning";
        private const string ErrorLevel = "Error";

        private readonly SqlExecutor _sqlExecutor;

        public DatabaseLogger(SqlExecutor sqlExecutor)
        {
            ArgumentNullException.ThrowIfNull(sqlExecutor);

            _sqlExecutor = sqlExecutor;
        }

        #region Login / Logout

        public void Login(
            long userId,
            string? fullName,
            string? email,
            string? branchCode,
            string? systemCode)
        {
            Write(
                logLevel: Information,
                title: "User Login",
                message: "User logged in successfully.",
                userId: userId,
                fullName: fullName,
                email: email,
                branchCode: branchCode,
                systemCode: systemCode);
        }

        public void Logout(
            long userId,
            string? fullName,
            string? email)
        {
            Write(
                logLevel: Information,
                title: "User Logout",
                message: "User logged out.",
                userId: userId,
                fullName: fullName,
                email: email);
        }

        #endregion

        #region Information

        public void Info(
            string title,
            string message)
        {
            Write(
                logLevel: Information,
                title: title,
                message: message);
        }

        #endregion

        #region Warning

        public void Warning(
            string title,
            string message)
        {
            Write(
                logLevel: WarningLevel,
                title: title,
                message: message);
        }

        #endregion

        #region Error

        public void Error(Exception exception)
        {
            Error("Application", exception);
        }

        public void Error(
            string title,
            Exception exception)
        {
            Error(title, exception, null);
        }

        public void Error(
            string title,
            Exception exception,
            string? sql,
            params SqlParameter[] parameters)
        {
            if (exception == null)
                return;

            StringBuilder parameterBuilder = new();

            if (parameters is { Length: > 0 })
            {
                foreach (SqlParameter parameter in parameters)
                {
                    parameterBuilder.AppendLine(
                        $"{parameter.ParameterName} = {parameter.Value}");
                }
            }

            Write(
                logLevel: ErrorLevel,
                title: title,
                message: exception.Message,
                exceptionType: exception.GetType().FullName,
                stackTrace: exception.StackTrace,
                source: exception.Source,
                sqlStatement: sql,
                sqlParameters: parameterBuilder.ToString());
        }

        #endregion

        #region Private

        private void Write(
            string logLevel,
            string title,
            string message,
            long? userId = null,
            string? fullName = null,
            string? email = null,
            string? branchCode = null,
            string? systemCode = null,
            string? exceptionType = null,
            string? stackTrace = null,
            string? source = null,
            string? sqlStatement = null,
            string? sqlParameters = null)
        {
            try
            {
                StringBuilder builder = new();

                if (userId.HasValue)
                    builder.AppendLine($"User ID     : {userId}");

                if (!string.IsNullOrWhiteSpace(fullName))
                    builder.AppendLine($"Full Name   : {fullName}");

                if (!string.IsNullOrWhiteSpace(email))
                    builder.AppendLine($"Email       : {email}");

                if (!string.IsNullOrWhiteSpace(branchCode))
                    builder.AppendLine($"Branch Code : {branchCode}");

                if (!string.IsNullOrWhiteSpace(systemCode))
                    builder.AppendLine($"System Code : {systemCode}");

                if (!string.IsNullOrWhiteSpace(message))
                {
                    if (builder.Length > 0)
                        builder.AppendLine();

                    builder.AppendLine(message);
                }

                _sqlExecutor.ExecuteProcedureNonQuery(
                    "SystemLog_Save",

                    SqlExecutor.Parameter("@LogLevel", logLevel, SqlDbType.NVarChar),
                    SqlExecutor.Parameter("@Title", title, SqlDbType.NVarChar),
                    SqlExecutor.Parameter("@Message", builder.ToString(), SqlDbType.NVarChar),

                    SqlExecutor.Parameter("@ExceptionType", (object?)exceptionType ?? DBNull.Value, SqlDbType.NVarChar),
                    SqlExecutor.Parameter("@StackTrace", (object?)stackTrace ?? DBNull.Value, SqlDbType.NVarChar),
                    SqlExecutor.Parameter("@Source", (object?)source ?? DBNull.Value, SqlDbType.NVarChar),

                    SqlExecutor.Parameter("@MachineName", Environment.MachineName, SqlDbType.NVarChar),
                    SqlExecutor.Parameter("@UserName", Environment.UserName, SqlDbType.NVarChar),
                    SqlExecutor.Parameter("@ApplicationName", AppDomain.CurrentDomain.FriendlyName, SqlDbType.NVarChar),

                    SqlExecutor.Parameter("@SqlStatement", (object?)sqlStatement ?? DBNull.Value, SqlDbType.NVarChar),
                    SqlExecutor.Parameter("@Parameters", (object?)sqlParameters ?? DBNull.Value, SqlDbType.NVarChar));
            }
            catch
            {
                // Logger should never throw.
            }
        }

        #endregion
    }
}
