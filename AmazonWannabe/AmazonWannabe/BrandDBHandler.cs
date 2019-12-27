using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    static class BrandDBHandler
    {
        public static bool Add(Brand brand)
        {
            string name = brand.getBrandName();
            string category = brand.getBrandCategory();
            string addQuery = "INSERT INTO BRAND(NAME , CATEGORY)" +
                              "VALUES('" + name + "' , '" + category + "')";

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

        public static List<Brand> Get()
        {
            string query = "SELECT NAME , CATEGORY FROM BRAND";
            List<Brand> ret = new List<Brand>();
            SQLiteConnection connection = DBConnection.getConnection();
            
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ret.Add(new Brand(reader["Name"].ToString(), reader["category"].ToString()));
                    }
                }
            }
            
            return ret;
        }
    }
}
