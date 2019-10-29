using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class AdministratorHandler
    {
        private SqlConnection connection = new SqlConnection(Login_Form.connectionString);

        public bool addCustomer(Administrator admin)
        {
            string adminEmail = admin.getUserInfo().getEmail().Replace("'", "''");
            string adminPassword = admin.getUserInfo().getPassword().Replace("'", "''");
            string adminUsername = admin.getUserInfo().getUsername().Replace("'", "''");

            connection.Open();
            string query = "INSERT INTO USERINFO(email, password, username) VALUES ('" + adminEmail + "','" + adminPassword + "','" + adminUsername + "')";
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

            query = "INSERT INTO CUSTOMERS VALUES('" + adminEmail + "')";
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

        public bool login(Administrator customer)
        {
            if (customer == null)
                return false;

            string password = null;

            string customerEmail = customer.getUserInfo().getEmail().Replace("'", "''");
            string query = "SELECT password FROM CUSTOMER WHERE email = '" + customerEmail + "'";
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
