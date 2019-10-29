using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class CustomerHandler
    {
        private SqlConnection connection = new SqlConnection(Login_Form.connectionString);

        public bool addCustomer(Customer customer)
        {
            string customerEmail = customer.getUserInfo().getEmail().Replace("'", "''");
            string customerPassword = customer.getUserInfo().getPassword().Replace("'", "''");
            string customerUsername = customer.getUserInfo().getUsername().Replace("'", "''");

            connection.Open();
            string query = "INSERT INTO USE_INFO(email, password, username) VALUES ('" + customerEmail + "','" + customerPassword + "','" + customerUsername + "')";
            using (SqlCommand command = new SqlCommand(query, connection)) {
                try
                {
                    command.ExecuteNonQuery();
                } 
                catch (SqlException)
                {
                    return false;
                }
            }

            query = "INSERT INTO CUSTOMERS VALUES('" + customerEmail + "')";
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

        public bool login(Customer customer)
        {
            if (customer == null)
                return false;

            string password = null;

            string customerEmail = customer.getUserInfo().getEmail().Replace("'", "''");
            string query = "SELECT password FROM CUSTOMERS WHERE email = '" + customerEmail + "'";
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                password = command.ExecuteScalar().ToString();
            }
            connection.Close();

            if (password == customer.getUserInfo().getPassword())
                return true;
            return false;
        }
    }
}
