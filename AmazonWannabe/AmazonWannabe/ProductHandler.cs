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
            string itemName = product.getName().Replace("'", "''");
            string addQuery = "INSERT INTO PRODUCTS(NAME , PRICE , ITEMNAME)" +
                              "VALUES('" + name + "' , " + price + " , '" + itemName + "')";
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(addQuery, connection))
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
    }
}
