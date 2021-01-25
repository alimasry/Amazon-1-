﻿using System;
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
    public partial class AddCollaborator_Form : Form
    {
        public AddCollaborator_Form()
        {
            InitializeComponent();

            initializeStores();
        }

        private void initializeStores()
        {
            string email = CredentialHandler.getCurrentUser().getEmail();

            List<Store> stores = StoreDBHandler.Get(email , null , true);

            foreach (Store store in stores)
                collaboratorStores.Items.Add(store.getStoreName());
        }

        private void addCollaboratorButton_Click(object sender, EventArgs e)
        {
            string email = collaboratorEmail.Text;
            string storeName = collaboratorStores.Text;
            if (email == "" || storeName == "")
                MessageBox.Show("Please fill all entries.");
            else if (email == CredentialHandler.getCurrentUser().getEmail())
                MessageBox.Show("You can't add your own email.");
            else
            {
                if (Collaborator.Add(email, storeName))
                    MessageBox.Show("Collaborator Added Successfully.");
                else
                    MessageBox.Show("Couldn't Add Collaborator.");
            }
        }
    }
}
