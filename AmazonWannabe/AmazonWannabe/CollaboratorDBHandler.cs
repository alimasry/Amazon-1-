﻿using System;
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
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
            
            return true;
        }
    }
}
