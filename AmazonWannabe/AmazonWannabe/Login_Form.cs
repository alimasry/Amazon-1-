using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    public partial class Login_Form : Form
    {
        public const string connectionString = "Data Source=database.sqlite3";

        Dictionary<string, Form> typeToForm = new Dictionary<string, Form>();
        FormEditor editor = new FormEditor();
        public Login_Form()
        {
            InitializeComponent();
            editor.EditButtons(this);
            editor.EditButtons(registerPanel);
            registerPanel.Visible = false;
            registerPanel.BringToFront();

            typeToForm.Add("Administrator", new Administrator_Form());
            typeToForm.Add("Store Owner", new StoreOwner_Form());
            typeToForm.Add("Customer", new Search_Form());
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerPanel.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            registerPanel.Visible = false;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if(passRegisterBox.Text != confpassRegisterBox.Text)
            {
                MessageBox.Show("Password and Confirm password does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = emailRegisterBox.Text.Replace("'", "''");
            string password = passRegisterBox.Text.Replace("'", "''");
            string username = userRegisterBox.Text.Replace("'", "''");
            string type = typeRegisterBox.Text;

            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO [USER INFO](email, password, username , type) VALUES ('" + email + "','" + password + "','" + username + "','" + type + "')";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SQLiteException)
                {
                    MessageBox.Show("Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    return;
                }
            }

            query = "INSERT INTO [" + type + "] VALUES('" + email + "')";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SQLiteException)
                {
                    MessageBox.Show("Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    return;
                }
            }

            connection.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string res = "";

            string password = passLoginBox.Text.Replace("'", "''");
            string email = emailLoginBox.Text.Replace("'", "''");
            string queryCheckUser = "SELECT count(*) FROM [USER INFO]\n" +
                                    "WHERE EMAIL = '" + email + "'\n" +
                                    "and PASSWORD = '" + password + "'\n";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(queryCheckUser, connection))
            {
                res = command.ExecuteScalar().ToString();
            }

            if (res == "0")
            {
                MessageBox.Show("Username or Password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return;
            }

            string queryGetType = "SELECT type from [user info]\n" +
                                  "where email = '" + email + "'\n";
            using(SQLiteCommand command = new SQLiteCommand(queryGetType , connection))
            {
                this.Visible = false;
                typeToForm[command.ExecuteScalar().ToString()].ShowDialog();
            }

            connection.Close();
        }
    }
}
