using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class StoreOwnerHandler
    {
        private SqlConnection connection = new SqlConnection(Login_Form.connectionString);

        public bool addStoreOwner(StoreOwner storeOwner)
        {
            string StoreOwnerEmail = storeOwner.getUserInfo().getEmail().Replace("'", "''");
            string storeOwnerPassword = storeOwner.getUserInfo().getPassword().Replace("'", "''");
            string storeOwnerUsername = storeOwner.getUserInfo().getUsername().Replace("'", "''");

            connection.Open();
            string query = "INSERT INTO USER_INFO(email, password, username) VALUES ('" + StoreOwnerEmail + "','" + storeOwnerPassword + "','" + storeOwnerUsername + "')";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    return false;
                }
            }

            query = "INSERT INTO CUSTOMERS VALUES('" + StoreOwnerEmail + "')";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    return false;
                }
            }

            connection.Close();
            return true;
        }

        public bool login(StoreOwner storeOwner)
        {
            if (storeOwner == null)
                return false;

            string password = null;

            string storeOwnerEmail = storeOwner.getUserInfo().getEmail().Replace("'", "''");
            string query = "SELECT password FROM CUSTOMERS WHERE email = '" + storeOwnerEmail + "'";
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                password = command.ExecuteScalar().ToString();
            }
            connection.Close();

            if (password == storeOwner.getUserInfo().getPassword())
                return true;
            return false;
        }
    }
}
