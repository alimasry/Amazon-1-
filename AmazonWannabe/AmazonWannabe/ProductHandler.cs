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
        private SQLiteConnection connection = new SQLiteConnection(Login_Form.connectionString);
        public bool addProduct(Product product)
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
            MessageBox.Show(addQuery);
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
                    connection.Close();
                    return false;
                }
            }
            connection.Close();

            return true;
        }
        public List<Product> getProducts()
        {
            string query = "SELECT ID , name , price , stocknum , itemname , storename , brandname FROM product";
            List<Product> ret = new List<Product>();
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                SQLiteDataReader reader = command.ExecuteReader();
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
                            new Item(reader["itemname"].ToString(), 0, 0)));
                    }
                    catch(SQLiteException e)
                    { 
                        MessageBox.Show(e.Message);
                        connection.Close();
                    }
                }
              
            }
            connection.Close();
            return ret;
        }
        public int checkStock(int amount,int ID)
        {
            int updated;
            string SQLquery2 = "Select StockNum from [Product] where ID='" + ID + "'\n";
            
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(SQLquery2, connection))
            {
                try
                {
                   SQLiteDataReader rd = command.ExecuteReader();
                   rd.Read();
                   updated = rd.GetInt32(0);
                }
                catch (SQLiteException e)
                {
                   MessageBox.Show(e.Message);
                   connection.Close();
                   return 0;
                }
            }
            connection.Close();
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

        public int updateStock(int updated, int ID)
        {
            string SQLquery3 = "UPDATE [Product] set StockNum ='" + updated + "'where ID='" + ID + "'\n";
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(SQLquery3, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        MessageBox.Show(e.Message);
                        connection.Close();
                        return 0;
                    }
                }
                connection.Close();
                return updated;
        }
    }
}
