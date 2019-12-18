using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class DBConnection
    {
        public const string connectionString = @"Data Source=..\..\database.sqlite3";

        private DBConnection() { }

        public static SQLiteConnection getConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}
