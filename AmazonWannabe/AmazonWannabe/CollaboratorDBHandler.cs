using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    static class CollaboratorDBHandler
    {
        public static bool Add(string email, string storeName)
        {
            string query = "INSERT INTO COLLABORATOR(EMAIL, STORE) VALUES('" + email + "', '" + storeName + "')";
            SQLiteConnection connection = DBConnection.getConnection();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch(SQLiteException e)
                {
                    //MessageBox.Show(e.Message);
                    return false;
                }
            }
            
            return true;
        }

        public static bool isCollaborator(string email)
        {
            string query = "SELECT COUNT(*) FROM COLLABORATOR WHERE EMAIL = '" + email + "'";

            SQLiteConnection connection = DBConnection.getConnection();

            string res = null;
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                try
                {
                    res = command.ExecuteScalar().ToString();
                }
                catch(SQLiteException)
                {
                    return false;
                }
            }
            return res != "0";
        }
    }
}
