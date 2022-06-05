using System;

namespace DesignDatabaseConnection
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        private readonly TimeSpan _timeout;

        public string ConnectionString => _connectionString;
        public TimeSpan Timeout => _timeout;

        public DbConnection(string connectionString, TimeSpan timeout)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException();

            _connectionString = connectionString;
            _timeout = timeout;
        }

        public abstract void Open();
        public abstract void Close();
    }
}