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
    public partial class Administrator_Form : Form
    {
        FormEditor editor = new FormEditor();
        Administrator admin;

        public Administrator_Form()
        {
            InitializeComponent();

            admin = new Administrator(CredentialHandler.getCurrentUser());

            editor.EditButtons(this);
            pendingStoresPanel.Visible = false;
            panel2.Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || minPriceBox.Text == "" || maxPriceBox.Text == "")
                return;
            Item item = new Item(nameBox.Text, Convert.ToDouble(minPriceBox.Text), Convert.ToDouble(maxPriceBox.Text));
            if (!admin.AddItem(item))
            {
                MessageBox.Show("Could not create item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Item created successfully.", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ViewPendingButton_Click(object sender, EventArgs e)
        {   
           if (StoreDBHandler.GetPending() != null)
                StoresGridView.DataSource = StoreDBHandler.GetPending();

            pendingStoresPanel.BringToFront();
            pendingStoresPanel.Visible = true;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Approve_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = StoresGridView.CurrentRow;
            if (selectedRow == null)
                return;
            string StoreName = Convert.ToString(selectedRow.Cells[0].Value);
            
            if (StoreName != null)
            {
                StoreDBHandler.Approve(StoreName);
            }
            else
                MessageBox.Show("Please select a specific row");
            
        }

        private void closeButton2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string brandName = Name_box.Text;
            string brandCategory = Category_box.Text;
            Brand brand = new Brand(brandName, brandCategory);
            if(!admin.AddBrand(brand))
            {
                MessageBox.Show("Could not create brand.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void Add_Brand_Click_1(object sender, EventArgs e)
        {
            panel2.BringToFront();
            panel2.Visible = true;
        }

        private void addStatsButton_Click(object sender, EventArgs e)
        {
            AdminStats_Form adminStatForm = new AdminStats_Form();
            adminStatForm.ShowDialog();
            adminStatForm.Dispose();
        }
    }
}
