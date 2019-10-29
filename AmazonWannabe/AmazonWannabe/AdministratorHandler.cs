using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    class AdministratorHandler
    {
        private SqlConnection connection = new SqlConnection(Login_Form.connectionString);

        public bool addAdministrator(Administrator admin)
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
                    connection.Close();
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
                    connection.Close();
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
            string res = null;

            string administratorEmail = admin.getUserInfo().getEmail().Replace("'", "''");
            string queryCheckPassword = "SELECT PASSWORD FROM USER_INFO WHERE EMAIL = '" + administratorEmail + "'";
            string queryCheckAdmin = "SELECT count(EMAIL) FROM ADMINISTRATORS WHERE email = '" + administratorEmail + "'";
            connection.Open();
            using (SqlCommand command = new SqlCommand(queryCheckPassword, connection))
            {
                password = command.ExecuteScalar().ToString();
            }
            using (SqlCommand command = new SqlCommand(queryCheckAdmin , connection))
            {
                res = command.ExecuteScalar().ToString();
            }
            connection.Close();

            if (password == admin.getUserInfo().getPassword() &&  res != "0")
                return true;
            return false;
        }
    }
}
