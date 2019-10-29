using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    class ProductHandler
    {
        private SqlConnection connection = new SqlConnection(Login_Form.connectionString);
        public bool addProduct(Product product)
        {
            if (product.getPrice() > product.getMaxPrice() || product.getPrice() < product.getMinPrice())
                return false;

            string name = product.getName().Replace("'", "''");
            string price = product.getPrice().ToString();
            string itemName = product.getItemName().Replace("'" , "''");
            string addQuery = "INSERT INTO PRODUCTS(NAME , PRICE , ITEMNAME)" +
                              "VALUES('" + name + "' , " + price + " , '" + itemName + "')";
            connection.Open();
            using (SqlCommand command = new SqlCommand(addQuery, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException e)
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
