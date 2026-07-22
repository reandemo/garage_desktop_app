using System;
using System.Data;
using Store_Online.Core.Database;

namespace Store_Online.Core.Services
{
    public class LoginHistoryService
    {
        private readonly SqlExecutor _db;

        public LoginHistoryService(SqlExecutor db)
        {
            _db = db;
        }

        public void SaveLoginHistory(
            int userId,
            string email,
            string status)
        {
            _db.Execute(

                @"INSERT INTO LoginHistory
                (
                    UserId,
                    Email,
                    LoginTime,
                    ComputerName,
                    UserName,
                    AppVersion,
                    Status
                )

                VALUES
                (
                    @UserId,
                    @Email,
                    @LoginTime,
                    @ComputerName,
                    @UserName,
                    @AppVersion,
                    @Status
                )",

                CommandType.Text,

                SqlExecutor.Parameter("@UserId", userId, SqlDbType.Int),

                SqlExecutor.Parameter("@Email", email, SqlDbType.NVarChar),

                SqlExecutor.Parameter("@LoginTime", DateTime.Now, SqlDbType.DateTime),

                SqlExecutor.Parameter("@ComputerName", Environment.MachineName, SqlDbType.NVarChar),

                SqlExecutor.Parameter("@UserName", Environment.UserName, SqlDbType.NVarChar),

                SqlExecutor.Parameter(
                    "@AppVersion",
                    System.Reflection.Assembly
                        .GetExecutingAssembly()
                        .GetName()
                        .Version?
                        .ToString(),
                    SqlDbType.NVarChar),

                SqlExecutor.Parameter("@Status", status, SqlDbType.NVarChar)
            );
        }
    }
}
