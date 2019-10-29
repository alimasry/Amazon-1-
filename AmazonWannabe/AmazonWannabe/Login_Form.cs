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
        private const string serverName = "DESKTOP-QF9IM65";
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
    }
}
