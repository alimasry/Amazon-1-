using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    class ProductDBHandler
    {
        public List<Product> productsQuery()
        {
            string query = "SELECT ID , name , price , stocknum , itemname , storename , brandname FROM product";
            List<Product> ret = new List<Product>();
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
                                ret.Add(new Product(reader["id"].ToString(),
                                    reader["name"].ToString(),
                                    Convert.ToDouble(reader["price"]),
                                    Convert.ToInt32(reader["stocknum"]),
                                    reader["Storename"].ToString(),
                                    reader["brandname"].ToString(),
                                    new Item(reader["itemname"].ToString(), 0, 0)));
                            }
                            catch (SQLiteException e)
                            {
                                MessageBox.Show(e.Message);
                            }
                        }
                    }
                }
            }
            return ret;
        }
        public int checkStock(int amount, int ID)
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

        public int updateStock(int updated, int ID)
        {
            string SQLquery3 = "UPDATE [Product] set StockNum =" + updated + " where ID=" + ID + "\n";
            using (SQLiteConnection connection = DBConnection.getConnection())
            {
                connection.Open();
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
            }

            return updated;
        }
    }
}
