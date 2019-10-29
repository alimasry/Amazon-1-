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
            string query = "INSERT INTO USER_INFO(email, password, username) VALUES ('" + adminEmail + "','" + adminPassword + "','" + adminUsername + "')";
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

            query = "INSERT INTO ADMINISTRATORS VALUES('" + adminEmail + "')";
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

        public bool login(Administrator admin)
        {
            if (admin == null)
                return false;

            string password = null;

            string customerEmail = admin.getUserInfo().getEmail().Replace("'", "''");
            string query = "SELECT password FROM ADMINISTRATORS WHERE email = '" + customerEmail + "'";
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                password = command.ExecuteScalar().ToString();
            }
            connection.Close();

            if (password == admin.getUserInfo().getPassword())
                return true;
            return false;
        }
    }
}
