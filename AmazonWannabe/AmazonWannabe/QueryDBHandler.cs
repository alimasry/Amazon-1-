using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    static class QueryDBHandler
    {
        public static bool addQuery(string name, string type, string field)
        {
            name = name.Replace("'", "''");
            type = type.Replace("'", "''");
            field = field.Replace("'", "''");
            string query = "INSERT INTO QUERY([NAME], [TYPE], [FIELD]) VALUES ('"
                + name + "','" + type + "','" + field + "')";

            //MessageBox.Show(query);

            SQLiteConnection connection = DBConnection.getConnection();
            
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SQLiteException)
                {
                    return false;
                }
            }

            return true;
        }

        public static string execQuery(string email, string type, string field)
        {
            string q = "SELECT " + type + "(" + field + ") FROM STORE WHERE EMAIL = '" + email + "'";
            string value = "";

            SQLiteConnection connection = DBConnection.getConnection();

            using (SQLiteCommand command = new SQLiteCommand(q, connection))
            {
                value = command.ExecuteScalar().ToString();
            }

            if (value == "")
                value = "0";

            return value;
        }

        public static List<object[]> Get()
        {
            string query = "SELECT * FROM QUERY";
            List<object[]> ret = new List<object[]>();

            SQLiteConnection connection = DBConnection.getConnection();
            
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ret.Add(new object[] { reader["name"].ToString(),
                        reader["type"].ToString(), reader["field"].ToString()});
                    }
                }
            }
            
            return ret;
        }
    }
}
