using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    class StoreHistoryDBHandler
    {
        public bool Add(StoreHistory storeHistory)
        {
            string name = storeHistory.StoreName;
            string productName = storeHistory.ProductName;
            string action = storeHistory.Action;
            string productID = storeHistory.ProductID;
            string itemName = storeHistory.ItemName;
            string brandName = storeHistory.BrandName;
            int stockNum = storeHistory.StockNum;
            double price = storeHistory.Price;


            string query = "INSERT INTO [STORE HISTORY]" +
                           "(PRODUCTNAME , STORENAME , ACTION , PRODUCTID , ITEMNAME , BRANDNAME , STOCKNUM , PRICE)" +
                           "VALUES('" + productName + "'," +
                           "'" + name + "'," +
                           "'" + action + "'," +
                           "" + productID + "," +
                           "'" + itemName + "'," +
                           "'" + brandName + "'," +
                           "" + stockNum + "," +
                           "" + price + ")";
            using (SQLiteConnection connection = DBConnection.getConnection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query , connection))
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

        public bool Delete(string ID)
        {
            string query = "DELETE FROM [STORE HISTORY] WHERE ID = " + ID;

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
        public List<StoreHistory> Get(string name)
        {
            string query = "SELECT * FROM [STORE HISTORY] WHERE STORENAME = '" + name + "'";
            List<StoreHistory> ret = new List<StoreHistory>();
            using (SQLiteConnection connection = DBConnection.getConnection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                ret.Add(new StoreHistory(reader["id"].ToString(),
                                    reader["storename"].ToString(),
                                    reader["productname"].ToString(),
                                    reader["action"].ToString(),
                                    reader["productid"].ToString(),
                                    reader["itemname"].ToString(),
                                    reader["brandname"].ToString(),
                                    Convert.ToInt32(reader["stocknum"].ToString()),
                                    Convert.ToDouble(reader["price"].ToString())));
                            }
                            catch (SQLiteException)
                            {
                                return null;
                            }
                        }
                    }
                }

            }
            return ret;
        }
    }
}
