﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class ItemHandler
    {
        private SQLiteConnection connection = new SQLiteConnection(Login_Form.connectionString);
        public bool addItem(Item item)
        {
            string name = item.getName().Replace("'", "''");
            string brand = item.getBrand().Replace("'", "''");
            string maxPrice = item.getMaxPrice().ToString();
            string minPrice = item.getMinPrice().ToString();
            string addQuery = "INSERT INTO ITEM(NAME , BRAND , MAXPRICE , MINPRICE)" +
                              "VALUES('" + name + "' , '" + brand +  "' , " + maxPrice + " , " + minPrice + ")";
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(addQuery, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SQLiteException)
                {
                    connection.Close();
                    return false;
                }
            }

            return true;
        }
        public List<Item> getItems()
        {
            string query = "SELECT NAME , BRAND , MINPRICE , MAXPRICE FROM ITEM";
            List<Item> ret = new List<Item>();
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new Item(reader["Name"].ToString() , reader["Brand"].ToString() , Convert.ToDouble(reader["minPrice"]), Convert.ToDouble(reader["maxPrice"])));
                }
            }
            return ret;
        }
    }
}
