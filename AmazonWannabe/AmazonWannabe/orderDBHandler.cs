using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    class OrderDBHandler
    {
        public int checkTotal(string userEmail)
        {
            int ret;
            string SQLquery = "SELECT COUNT(OrderID) FROM [Order] WHERE userEmail='" + userEmail + "'";
            using (SQLiteConnection connection = DBConnection.getConnection())
            {
                connection.Open();
                using(SQLiteCommand command=new SQLiteCommand(SQLquery, connection))
                {
                    try
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            ret = reader.GetInt32(0);
                            reader.Close();
                            return ret;
                        }
                    }
                    catch (SQLiteException e)
                    {
                        MessageBox.Show(e.Message);
                        return 0;
                    }
                }
                connection.Close();
            }
            //return 0;
        }
        public void addOrderDB(float totalPrice, int amount, string address, int ID)
        {
            string userEmail = CredentialHandler.getCurrentUser().getEmail();
            string SQLquery = "insert into [Order]( Price, Amount , Address , productID , userEmail )\n" +
                                 "values(" + totalPrice + " , " + amount + " , '" + address + "' , " + ID + " , '" + userEmail + "')";
            using (SQLiteConnection connection = DBConnection.getConnection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(SQLquery, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        MessageBox.Show(e.Message);
                        return;
                    }
                }
            }
        }
    }
}
