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
        public bool Add(Store store)
        {
            string email = store.getEmail();
            int soldNum = store.getSoldNum();
            string approved = store.getApproved();
            string name = store.getStoreName();
            string location = store.getStoreLocation();
            string type = store.getStoreType();
            string addQuery = "insert into store(name , soldnum , type , location , approved , email)" +
                              "values('" + name + "' , " + soldNum + " , '" + type + "' , '" + location + "' , "  + approved + " , '" + email + "')";
            using (SQLiteConnection connection = DBConnection.getConnection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(addQuery, connection))
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
            }
            return true;
        }

        public bool addUserView(string storeName)
        {
            string incQuery = "UPDATE STORE SET USERVIEWS = USERVIEWS + 1 WHERE NAME = '" + storeName + "'";
            using (SQLiteConnection connection = DBConnection.getConnection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(incQuery, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public List<Store> Get(string email , string name = null)
        {
            string query = "SELECT * FROM store ";
            if (name != null)
                query += "WHERE NAME = " + name;
            List<Store> ret = new List<Store>();
            using (SQLiteConnection connection = DBConnection.getConnection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            ret.Add(new Store(reader["email"].ToString(),
                                    Int32.Parse(reader["soldNum"].ToString()),
                                    reader["approved"].ToString(), reader["name"].ToString(),
                                    reader["location"].ToString(), reader["type"].ToString(),
                                    Int32.Parse(reader["userviews"].ToString())));
                        }
                    }
                }
            }
            return ret;
        }
    }
}
