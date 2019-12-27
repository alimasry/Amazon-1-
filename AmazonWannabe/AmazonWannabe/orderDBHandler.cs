using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    static class OrderDBHandler
    {
        public static int checkTotal(string userEmail)
        {
            int ret;
            string SQLquery = "SELECT COUNT(OrderID) FROM [Order] WHERE USEREMAIL='" + userEmail + "'";
            SQLiteConnection connection = DBConnection.getConnection();
            
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
                catch (SQLiteException)
                {
                    return 0;
                }
            }
            
        }
        public static void Add(float totalPrice, int amount, string address, int ID)
        {
            string userEmail = CredentialHandler.getCurrentUser().getEmail();
            string SQLquery = "INSERT INTO [Order]( PRICE, AMOUNT , ADDRESS , PRODUCTID , USEREMAIL )\n" +
                                 "VALUES(" + totalPrice + " , " + amount + " , '" + address + "' , " + ID + " , '" + userEmail + "')";

            SQLiteConnection connection = DBConnection.getConnection();
            
            using (SQLiteCommand command = new SQLiteCommand(SQLquery, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SQLiteException)
                {
                    return;
                }
            }
            
        }
    }
}
