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
