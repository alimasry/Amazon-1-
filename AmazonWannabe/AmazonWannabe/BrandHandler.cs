﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class BrandHandler
    {
        private SQLiteConnection connection = new SQLiteConnection(Login_Form.connectionString);

        public bool addBrand(Brand brand)
        {
            string name = brand.getBrandName();
            string category = brand.getBrandCategory();
            string addQuery = "insert into brand(name , category)" +
                              "values('" + name + "' , '" + category + "')";

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
        public List<Brand> getBrands()
        {
            string query = "SELECT NAME , CATEGORY FROM BRAND";
            List<Brand> ret = new List<Brand>();
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new Brand(reader["Name"].ToString(), reader["category"].ToString()));
                }
            }
            return ret;
        }
    }
}