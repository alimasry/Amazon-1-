using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    static class DBConnection
    {
        public const string connectionString = @"Data Source=..\..\database.sqlite3";

        private static SQLiteConnection connection = null;

        public static SQLiteConnection getConnection()
        {
            if (connection == null)
            {
                connection = new SQLiteConnection(connectionString);
                connection.Open();
            }
            return connection;
        }
    }
}
