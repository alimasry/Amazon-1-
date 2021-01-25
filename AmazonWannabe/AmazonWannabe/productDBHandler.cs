using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    static class ProductDBHandler
    {
        private static List<Product> Get(string extension = null)
        {
            string query = "SELECT ID , name , price , stocknum , itemname , storename , brandname, Offer FROM product ";
            if (extension != null)
                query += "WHERE " + extension;

            List<Product> ret = new List<Product>();
            SQLiteConnection connection = DBConnection.getConnection();
            
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            ret.Add(new Product(reader["id"].ToString(),
                                reader["name"].ToString(),
                                Convert.ToDouble(reader["price"]),
                                Convert.ToInt32(reader["stocknum"]),
                                reader["Storename"].ToString(),
                                reader["brandname"].ToString(),
                                new Item(reader["itemname"].ToString(), 0, 0),
                                Convert.ToInt32(reader["Offer"])));
                        }
                        catch (SQLiteException e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }
                }
            }

            return ret;
        }

        public static List<Product> GetByName(string name)
        {
            return Get("NAME = '" + name + "'");
        }

        public static List<Product> GetByStoreName(string storeName)
        {
            return Get("STORENAME = '" + storeName + "'");
        }

        public static Product GetByID(string id)
        {
            List<Product> product = Get("ID = " + id);
            return product[0];
        }

        public static List<Product> Get()
        {
            return Get(null);
        }

        public static string GetLatestID()
        {
            string query = "SELECT MAX(ID) FROM PRODUCT";
            string ret;

            SQLiteConnection connection = DBConnection.getConnection();
            
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                try
                {
                    ret = command.ExecuteScalar().ToString();
                }
                catch (SQLiteException)
                {
                    return null;
                }
            }

            return ret;

        }

        public static bool Add(Product product)
        {
            string name = product.getName().Replace("'", "''");
            double price = product.getPrice();
            string itemName = product.getItemName().Replace("'", "''");
            string store = product.getStoreName().Replace("'", "''");
            string brand = product.getBrandName().Replace("'", "''");
            int stockNum = product.getStockNum();
            string addQuery = "INSERT INTO PRODUCT(NAME , PRICE , ITEMNAME, STORENAME , BRANDNAME , STOCKNUM)" +
                              "VALUES('" + name + "' , " + price + " , '" + itemName + "' , '" + store + "' , '" + brand + "'," + stockNum + ")";
            SQLiteConnection connection = DBConnection.getConnection();
            
            using (SQLiteCommand command = new SQLiteCommand(addQuery, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SQLiteException e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }

            return true;
        }

        public static bool Delete(string productId)
        {
            string query = "DELETE FROM PRODUCT WHERE ID = " + productId;

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

        public static bool Update(Product product)
        {
            string name = product.getName().Replace("'", "''");
            double price = product.getPrice();
            string itemName = product.getItemName().Replace("'", "''");
            string storeName = product.getStoreName().Replace("'", "''");
            string brandName = product.getBrandName().Replace("'", "''");
            int stockNum = product.getStockNum();

            string query = "UPDATE PRODUCT SET " +
                           "NAME = '" + name + "'," +
                           "PRICE = " + price + "," +
                           "STOCKNUM = " + stockNum + "," +
                           "ITEMNAME = '" + itemName + "'," +
                           "STORENAME = '" + storeName + "'," +
                           "BRANDNAME = '" + brandName + "' " +
                           "WHERE ID = " + product.getId();
            SQLiteConnection connection = DBConnection.getConnection();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SQLiteException e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }

            return true;
        }

        public static int checkStock(int ID)
        {
            int updated;
            string SQLquery2 = "Select StockNum from [Product] where ID='" + ID + "'\n";

            SQLiteConnection connection = DBConnection.getConnection();
            
            using (SQLiteCommand command = new SQLiteCommand(SQLquery2, connection))
            {
                try
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        updated = reader.GetInt32(0);
                        reader.Close();
                    }
                }
                catch (SQLiteException e)
                {
                    MessageBox.Show(e.Message);
                    return -1;
                }
            }

            return updated;
        }

        public static int updateStock(int updated, int ID)
        {
            string SQLquery3 = "UPDATE [Product] set StockNum =" + updated + " where ID=" + ID + "\n";
            SQLiteConnection connection = DBConnection.getConnection();
            
            using (SQLiteCommand command = new SQLiteCommand(SQLquery3, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SQLiteException e)
                {
                    MessageBox.Show(e.Message + "1");
                    return 0;
                }
            }

            return updated;
        }

        public static void updateDBOffer(int ID,int Percentage)
        {
            string SQLquery3 = "UPDATE [Product] set Offer =" + Percentage + " where ID=" + ID + "\n";
            SQLiteConnection connection = DBConnection.getConnection();
            
            using (SQLiteCommand command = new SQLiteCommand(SQLquery3, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Offers Successfully Updated");
                }
                catch (SQLiteException e)
                {
                    MessageBox.Show(e.Message + "1");
                }
            }
        }
    }
}
