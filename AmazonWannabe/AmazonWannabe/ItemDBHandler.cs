using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    static class ItemDBHandler
    {
        public static bool Add(Item item)
        {
            string name = item.getItemName().Replace("'", "''");
            string maxPrice = item.getMaxPrice().ToString();
            string minPrice = item.getMinPrice().ToString();
            string addQuery = "INSERT INTO ITEM(NAME , MAXPRICE , MINPRICE)" +
                              "VALUES('" + name + "' , " + maxPrice + " , " + minPrice + ")";
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
        public static List<Item> Get()
        {
            string query = "SELECT NAME , MINPRICE , MAXPRICE FROM ITEM";
            List<Item> ret = new List<Item>();
            SQLiteConnection connection = DBConnection.getConnection();
            
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ret.Add(new Item(reader["Name"].ToString(), Convert.ToDouble(reader["minPrice"]), Convert.ToDouble(reader["maxPrice"])));
                    }
                }
            }
            
            return ret;
        }
        public static Item GetByName(string name)
        {
            string query = "SELECT NAME , MINPRICE , MAXPRICE FROM ITEM WHERE NAME = '" + name + "'";

            Item ret = null;

            SQLiteConnection connection = DBConnection.getConnection();
            
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    double minPrice = Convert.ToDouble(reader["minprice"].ToString());
                    double maxPrice = Convert.ToDouble(reader["maxprice"].ToString());

                    ret = new Item(name, minPrice, maxPrice);
                }
            }

            return ret;
        }
    }
}
