﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    class UserDBHandler : IDBHandler
    {
        public bool Insert(object user)
        {
            UserInfo userInfo = (UserInfo)user;
            string email = userInfo.getEmail().Replace("'", "''");
            string password = userInfo.getPassword().Replace("'", "''");
            string username = userInfo.getUsername().Replace("'", "''");
            string type = userInfo.getType().Replace("'", "''");

            string query = "INSERT INTO [USER INFO](email, password, username , type) VALUES ('" + email + "','" +
                password + "','" + username + "','" + type + "')";

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

            query = "INSERT INTO [" + type + "] VALUES('" + email + "')";
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

        public bool Remove(object customer)
        {
            throw new NotImplementedException();
        }

        public UserInfo get(string email, string password)
        {
            string queryCheckUser = "SELECT [TYPE], [USERNAME] FROM [USER INFO]\n" +
                                    "WHERE EMAIL = '" + email.Replace("'", "''") + "'\n" +
                                    "and PASSWORD = '" + password.Replace("'", "''") + "'\n";

            using (SQLiteConnection connection = DBConnection.getConnection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(queryCheckUser, connection))
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string type = reader["TYPE"].ToString();
                        string username = reader["USERNAME"].ToString();
                        return new UserInfo(email, password, username, type);
                    }
                    else
                        return null;
                }
            }
        }
    }
}
