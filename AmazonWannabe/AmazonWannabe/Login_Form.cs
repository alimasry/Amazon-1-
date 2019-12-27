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
        
        public UserInfo userInfo = null;

        FormEditor editor = new FormEditor();
        public Login_Form()
        {
            InitializeComponent();
            editor.EditButtons(this);
            editor.EditButtons(registerPanel);
            registerPanel.Visible = false;
            registerPanel.BringToFront();
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
            string email = emailRegisterBox.Text;
            string password = passRegisterBox.Text;
            string confirmPassword = confpassRegisterBox.Text;
            string username = userRegisterBox.Text;
            string type = typeRegisterBox.Text;

            if (CredentialHandler.register(username, email, password, confirmPassword, type))
                MessageBox.Show("Registration Succeceeded.");
            else
                MessageBox.Show("Registration Failed.");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string password = passLoginBox.Text;
            string email = emailLoginBox.Text;
            if (CredentialHandler.login(email, password))
            {
                this.Visible = false;
                Search_Form searchForm = new Search_Form();
                searchForm.ShowDialog();
                searchForm.Dispose();
                this.Close();
            }
            else
                MessageBox.Show("Login Failed.");
        }
    }
}
