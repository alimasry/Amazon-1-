using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    class StoreHandler
    {

        private SQLiteConnection connection = new SQLiteConnection(Login_Form.connectionString);
        
        public bool addStore(Store store)
        {
            string email = store.getEmail();
            int soldNum = store.getSoldNum();
            string approved = store.getApproved();
            string name = store.getStoreName();
            string location = store.getStoreLocation();
            string type = store.getStoreType();
            string addQuery = "insert into store(name , soldnum , type , location , approved , email)" +
                              "values('" + name + "' , " + soldNum + " , '" + type + "' , '" + location + "' , "  + approved + " , '" + email + "')";
            MessageBox.Show(addQuery);
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(addQuery, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SQLiteException)
                {
                    connection.Close();
                    return false;
                }
            }
            connection.Close();
            return true;
        }

        public bool addUserView(string storeName)
        {
            string incQuery = "UPDATE STORE SET USERVIEWS = USERVIEWS + 1 WHERE NAME = '" + storeName + "'";
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(incQuery, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SQLiteException e)
                {
                    connection.Close();
                    return false;
                }
            }
            connection.Close();
            return true;
        }

        public List<Store> getStores()
        {
            string query = "SELECT * FROM store";
            List<Store> ret = new List<Store>();
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new Store(reader["email"].ToString(), 
                            Int32.Parse(reader["soldNum"].ToString()),
                            reader["approved"].ToString() , reader["name"].ToString(),
                            reader["location"].ToString() , reader["type"].ToString(), 
                            Int32.Parse(reader["userviews"].ToString())));
                }
            }
            connection.Close();
            return ret;
        }
    }
}
