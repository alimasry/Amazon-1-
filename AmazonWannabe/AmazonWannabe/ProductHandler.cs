using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    class ProductHandler
    {

        ProductDBHandler productDB = new ProductDBHandler();
        OrderHandler order = new OrderHandler();
        public bool Add(Product product)
        {
            if (product.getPrice() > product.getMaxPrice() || product.getPrice() < product.getMinPrice())
                return false;

            string name = product.getName().Replace("'", "''");
            string price = product.getPrice().ToString();
            string itemName = product.getItemName().Replace("'", "''");
            string store = product.getStoreName().Replace("'", "''");
            string brand = product.getBrandName().Replace("'", "''");
            string addQuery = "INSERT INTO PRODUCT(NAME , PRICE , ITEMNAME, STORENAME , brandname)" +
                              "VALUES('" + name + "' , " + price + " , '" + itemName + "' , '" + store +"' , '" + brand + "')";
            using (SQLiteConnection connection = DBConnection.getConnection())
            {
                connection.Open();
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
            }

            return true;
        }

        public List<Product> GetByName(string name)
        {
            return Get("NAME = '" + name + "'");
        }
        public List<Product> GetByStoreName(string storeName)
        {
            return Get("STORENAME = '" + storeName + "'");
        }
        public List<Product> Get(string extension = null)
        {
            return productDB.productsQuery();
        }
        public string GetLatestID()
        {
            string query = "SELECT MAX(ID) FROM PRODUCT";
            string ret;

            using (SQLiteConnection connection = DBConnection.getConnection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    try
                    {
                        ret = command.ExecuteScalar().ToString();
                    }
                    catch (SQLiteException e)
                    {
                        return null;
                    }
                }
            }

            return ret;

        }
        public bool Delete(string productId)
        {
            string query = "DELETE FROM PRODUCT WHERE ID = " + productId;

            using (SQLiteConnection connection = DBConnection.getConnection())
            {
                connection.Open();
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
            }

            return true;
        }
        public bool Update(Product product)
        {
            string query = "UPDATE PRODUCT SET " +
                           "NAME = '" + product.getName() + "'," +
                           "PRICE = " + product.getPrice() + "," +
                           "STOCKNUM = " + product.getStockNum() + "," +
                           "ITEMNAME = '" + product.getItemName() + "'," +
                           "STORENAME = '" + product.getStoreName() + "'," +
                           "BRANDNAME = '" + product.getBrandName() + "' " +
                           "WHERE PRODUCTID = " + product.getId();
            using (SQLiteConnection connection = DBConnection.getConnection())
            {
                connection.Open();
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
            }

            return true;
        }
        public int checkStock(int amount,int ID)
        {
            int updated;
            string SQLquery2 = "Select StockNum from [Product] where ID='" + ID + "'\n";

            using (SQLiteConnection connection = DBConnection.getConnection())
            {
                connection.Open();
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
                        return 0;
                    }
                }
            }
            if (updated >= amount)
            {
                updated = updated - amount;
            }
            else
            {
                updated = 0;
            }
            return updated;
        }
        public void check(int amount, int ID, float price, string address)
        {
            int updated = productDB.checkStock(amount, ID);
            if (updated > 0)
            {
                productDB.updateStock(updated, ID);
                order.addOrder(price, amount, address, ID);
            }
        }
    }
}
