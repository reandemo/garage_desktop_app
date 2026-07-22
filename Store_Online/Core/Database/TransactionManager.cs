using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Store_Online.Core.Database
{
    public sealed class TransactionManager : IDisposable
    {
        private readonly DbConnectionFactory _connectionFactory;

        public SqlConnection Connection { get; }

        public SqlTransaction Transaction { get; private set; }

        private bool _disposed;

        public TransactionManager(DbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;

            Connection = _connectionFactory.CreateOpenConnection();

            Transaction = Connection.BeginTransaction();
        }

        /// <summary>
        /// Commit transaction.
        /// </summary>
        public void Commit()
        {
            Transaction.Commit();
        }

        /// <summary>
        /// Rollback transaction.
        /// </summary>
        public void Rollback()
        {
            Transaction.Rollback();
        }

        public void Dispose()
        {
            if (_disposed)
            {
                return;
            }

            Transaction.Dispose();
            Connection.Dispose();

            _disposed = true;

            GC.SuppressFinalize(this);
        }
    }
}
