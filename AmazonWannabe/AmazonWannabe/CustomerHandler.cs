﻿using System;
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
        private SQLiteConnection connection = new SQLiteConnection(Login_Form.connectionString);

        public void addOrder(float totalPrice,int amount,string address,int ID)
        {
            Form login = Application.OpenForms["Login_Form"];
            string userEmail = ((Login_Form)login).userInfo.getEmail();
            string SQLquery = "insert into [Order]( Price, Amount , Address , productID , userEmail )\n" +
                                 "values(" + totalPrice + " , " + amount + " , '" + address + "' , " + ID + " , '" + userEmail + "')";
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
                    MessageBox.Show(e.Message + "2");
                    connection.Close();
                    return;
                }
            }
            connection.Close();
        }
    }
}