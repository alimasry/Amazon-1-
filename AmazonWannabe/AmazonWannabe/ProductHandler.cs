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
        productDBHandler productDB = new productDBHandler();
        orderHandler order = new orderHandler();
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
        public List<Product> getProducts()
        {
            return productDB.productsQuery();
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
