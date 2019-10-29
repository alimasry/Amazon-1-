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
                    connection.Close();
                    return false;
                }
            }

            query = "INSERT INTO STORE_OWNERS VALUES('" + StoreOwnerEmail + "')";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    connection.Close();
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
            string res = null;

            string storeOwnerEmail = storeOwner.getUserInfo().getEmail().Replace("'", "''");
            string queryCheckPassword = "SELECT PASSWORD FROM USER_INFO WHERE EMAIL = '" + storeOwnerEmail + "'";
            string queryCheckOwner = "SELECT COUNT(*) FROM STORE_OWNERS WHERE email = '" + storeOwnerEmail + "'";
            connection.Open();
            using (SqlCommand command = new SqlCommand(queryCheckPassword, connection))
            {
                try
                {
                    password = command.ExecuteScalar().ToString();
                }
                catch
                {
                    connection.Close();
                    return false;
                }
            }
            using (SqlCommand command = new SqlCommand(queryCheckOwner, connection))
            {
                res = command.ExecuteScalar().ToString();
            }
            connection.Close();

            if (password == storeOwner.getUserInfo().getPassword() && res != "0")
                return true;
            return false;
        }
    }
}
