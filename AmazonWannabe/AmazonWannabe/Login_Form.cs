using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    public partial class Login_Form : Form
    {
        private const string serverName = @"DESKTOP-A32LPMS\FADY";
        private const string databaseName = "AmazonWannabe";
        public const string connectionString = "Data Source=" + serverName + ";Initial Catalog =" + databaseName + "; Integrated Security=True;";

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
            if (!editor.CheckTextBoxes(registerPanel) || typeRegisterBox.Text == "")
                return;

            if(passRegisterBox.Text != confpassRegisterBox.Text)
            {
                MessageBox.Show("Password and Confirm password does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserInfo userInfo = new UserInfo(emailRegisterBox.Text, userRegisterBox.Text, passRegisterBox.Text);

            if (typeRegisterBox.Text == "Customer")
            {
                CustomerHandler customerHandler = new CustomerHandler();
                Customer customer = new Customer(userInfo);
                if(!customerHandler.addCustomer(customer))
                {
                    MessageBox.Show("Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (typeRegisterBox.Text == "Administrator")
            {
                AdministratorHandler customerHandler = new AdministratorHandler();
                Administrator admin = new Administrator(userInfo);
                if (!customerHandler.addAdministrator(admin))
                {
                    MessageBox.Show("Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (typeRegisterBox.Text == "Store Owner")
            {
                StoreOwnerHandler customerHandler = new StoreOwnerHandler();
                StoreOwner storeOwner = new StoreOwner(userInfo);
                if (!customerHandler.addStoreOwner(storeOwner))
                {
                    MessageBox.Show("Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("Account created successfully.", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo(emailLoginBox.Text, emailLoginBox.Text, passLoginBox.Text);

            if (typeLoginBox.Text == "Customer")
            {
                CustomerHandler customerHandler = new CustomerHandler();
                Customer customer = new Customer(userInfo);
                if (!customerHandler.login(customer))
                {
                    MessageBox.Show("Username or Password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Search_Form form = new Search_Form();
                this.Visible = false;
                form.ShowDialog();
                form.Dispose();
                this.Close();
                return;
            }
            if (typeLoginBox.Text == "Administrator")
            {
                AdministratorHandler customerHandler = new AdministratorHandler();
                Administrator admin = new Administrator(userInfo);
                if (!customerHandler.login(admin))
                {
                    MessageBox.Show("Username or Password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Administrator_Form form = new Administrator_Form();
                this.Visible = false;
                form.ShowDialog();
                form.Dispose();
                this.Close();
                return;
            }
            if (typeLoginBox.Text == "Store Owner")
            {
                StoreOwnerHandler customerHandler = new StoreOwnerHandler();
                StoreOwner storeOwner = new StoreOwner(userInfo);
                if (!customerHandler.login(storeOwner))
                {
                    MessageBox.Show("Username or Password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                StoreOwner_Form form = new StoreOwner_Form();
                this.Visible = false;
                form.ShowDialog();
                form.Dispose();
                this.Close();
                return;
            }
        }
    }
}
