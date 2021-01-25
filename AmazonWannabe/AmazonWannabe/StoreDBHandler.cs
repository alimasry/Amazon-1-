using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    static class StoreDBHandler
    {
        public static bool Add(Store store)
        {
            string email = store.getEmail();
            int soldNum = store.getSoldNum();
            string approved = store.getApproved();
            string name = store.getStoreName();
            string location = store.getStoreLocation();
            string type = store.getStoreType();
            string addQuery = "INSERT INTO STORE(NAME , SOLDNUM , TYPE , LOCATION , APPROVED , EMAIL)" +
                              "VALUES('" + name + "' , " + soldNum + " , '" + type + "' , '" + location + "' , "  + approved + " , '" + email + "')";
            SQLiteConnection connection = DBConnection.getConnection();
            
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

            return true;
        }

        public static bool addUserView(string storeName)
        {
            string incQuery = "UPDATE STORE SET USERVIEWS = USERVIEWS + 1 WHERE NAME = '" + storeName + "'";

            SQLiteConnection connection = DBConnection.getConnection();
            
            using (SQLiteCommand command = new SQLiteCommand(incQuery, connection))
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

        public static List<Store> Get(string email , string name = null, bool ownedOnly = false)
        {
            string query = "SELECT * FROM STORE WHERE EMAIL = '" + email + "'";
            if (name != null)
                query += "WHERE NAME = '" + name + "'";
            List<Store> ret = new List<Store>();
            SQLiteConnection connection = DBConnection.getConnection();
            
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
            

            if (!ownedOnly)
            {
                query = "SELECT * FROM STORE INNER JOIN COLLABORATOR on " +
                    "STORE.NAME= COLLABORATOR.STORE WHERE COLLABORATOR.EMAIL = '" + email + "'";
            
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

        public static bool Approve(string storeName)
        {
            string query = "UPDATE STORE SET APPROVED=1 WHERE NAME='" + storeName + "'";

            SQLiteConnection connection = DBConnection.getConnection();

            using (SQLiteCommand SQLcommand = new SQLiteCommand(query, connection))
            {
                try
                {
                    SQLcommand.ExecuteNonQuery();
                }
                catch (SQLiteException)
                {
                    return false;
                }
            }

            return true;
        }

        public static DataTable GetPending()
        {
            SQLiteDataAdapter adapter;
            DataSet dataset = new DataSet();

            SQLiteConnection connection = DBConnection.getConnection();

            string query = "SELECT * FROM Store Where Approved=0";

            using (SQLiteCommand SQLcommand = new SQLiteCommand(query, connection))
            {
                try
                {
                    adapter = new SQLiteDataAdapter(SQLcommand);
                    adapter.Fill(dataset);
                    return dataset.Tables[0];
                }
                catch (SQLiteException)
                {
                    return null;
                }
            }
        }
    }
}
