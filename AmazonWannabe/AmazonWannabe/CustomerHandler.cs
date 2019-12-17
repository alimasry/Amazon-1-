using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    class CustomerHandler
    {

        public void addOrder(float totalPrice,int amount,string address,int ID)
        {
            string userEmail = CredentialHandler.getCurrentUser().getEmail();
            string SQLquery = "insert into [Order]( Price, Amount , Address , productID , userEmail )\n" +
                                 "values(" + totalPrice + " , " + amount + " , '" + address + "' , " + ID + " , '" + userEmail + "')";
            MessageBox.Show(SQLquery);
            using (SQLiteConnection connection = DBConnection.getConnection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(SQLquery, connection))
                {
                    try
                    {
                        MessageBox.Show(SQLquery);
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
