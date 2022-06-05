using System;

namespace DesignDatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {
        }

        public override void Open() => Console.WriteLine("Database is open.");
        public override void Close() => Console.WriteLine("Database is closed.");
    }
}