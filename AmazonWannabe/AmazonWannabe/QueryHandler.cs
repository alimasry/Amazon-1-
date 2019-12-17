using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    class QueryHandler
    {
        public void addQuery(string name, string type, string field)
        {
            name = name.Replace("'", "''");
            type = type.Replace("'", "''");
            field = field.Replace("'", "''");
            string query = "INSERT INTO QUERY([name], [type], [field]) values ('"
                + name + "','" + type + "','" + field + "')";

            MessageBox.Show(query);

            using (SQLiteConnection connection = DBConnection.getConnection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Query added successfully");
                    }
                    catch (SQLiteException)
                    {
                        MessageBox.Show("Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }
        }

        private object[] execQuery(object[] query)
        {
            Form login = Application.OpenForms["Login_Form"];
            string email = ((Login_Form)login).userInfo.getEmail().Replace("'", "''");
            string q = "Select " + query[1] + "(" + query[2] + ") from STORE WHERE EMAIL = '" + email + "'";
            String value;

            using (SQLiteConnection connection = DBConnection.getConnection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(q, connection))
                {
                    value = command.ExecuteScalar().ToString();
                }
            }
            return new object[] { query[0], value };
        }

        public List<object[]> getQueries()
        {
            string query = "SELECT * FROM QUERY";
            List<object[]> ret = new List<object[]>();
            using (SQLiteConnection connection = DBConnection.getConnection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        object[] q = execQuery(new object[] { reader["name"].ToString(),
                            reader["type"].ToString(), reader["field"].ToString()});
                        ret.Add(q);
                    }
                }
            }
            return ret;
        }
    }
}
