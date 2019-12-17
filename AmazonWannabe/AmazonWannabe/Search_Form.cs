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
    public partial class Search_Form : Form
    {
        FormEditor editor = new FormEditor();
        ItemHandler itemHandler = new ItemHandler();
        ProductHandler productHandler = new ProductHandler();
        List<Item> items = new List<Item>();
        CustomerHandler customerHandler = new CustomerHandler();

        public Search_Form(string type)
        {
            InitializeComponent();
            editor.EditButtons(this);
            Confirm_panel.Visible = false;
            items = itemHandler.Get();
            foreach (Item s in items)
            {
                searchItem.Items.Add(s.getItemName());
            }

            // TODO: make code below better
            if (type != "Administrator")
                adminFormButton.Visible = false;
            if (type != "Store Owner")
                storeOwnerFormButton.Visible = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<Product> products = productHandler.Get();
            foreach(Product p in products)
            {
                DataGridViewRow r = (DataGridViewRow)productsGrid.Rows[0].Clone();
                r.Cells[0].Value = p.getName();
                r.Cells[1].Value = p.getPrice();
                r.Cells[2].Value = p.getId();
                if (r.Cells[0].Value.ToString() != searchBar.Text && searchBar.Text != "")
                    continue;

                productsGrid.Rows.Add(r);
            }
        }

        private void productsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productsGrid_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = productsGrid.CurrentRow;
            if (selectedRow == null)
                return;
            string productName = Convert.ToString(selectedRow.Cells[0].Value);
            List<Product> products = productHandler.Get();

            Product product = null;
            foreach(Product p in products)
            {
                if (p.getName() == productName)
                {
                    product = p;
                }
            }
            ViewItem viewItem = new ViewItem(product);
            viewItem.ShowDialog();
            viewItem.Close();
        }

        private void Buy_button_Click(object sender, EventArgs e)
        {
            Confirm_panel.Visible = true;
            Confirm_panel.BringToFront();
        }

        private void Close_panel_Click(object sender, EventArgs e)
        {
            Confirm_panel.Visible = false;
            Confirm_panel.SendToBack();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (!Agreement.Checked)
            {
                MessageBox.Show("please select the checkbox to confirm");
            }
            DataGridViewRow selectedRow = productsGrid.CurrentRow;
            string productID = Convert.ToString(selectedRow.Cells[2].Value);
            int ID = int.Parse(productID);
            if (amountBox.Text == "" || addressBox.Text == "")
            {
                MessageBox.Show("please enter amount and address");
            }
            else
            {
                int amount = Int32.Parse(amountBox.Text);
                float totalPrice = Int32.Parse(amountBox.Text) * Int32.Parse(Convert.ToString(selectedRow.Cells[1].Value));
                string address = addressBox.Text;
                int updated=productHandler.checkStock(amount, ID);
                productHandler.updateStock(updated,ID);
                customerHandler.addOrder(totalPrice, amount, address, ID);
               
            }

        }

        private void AdminFormButton_Click(object sender, EventArgs e)
        {
            Administrator_Form adminForm = new Administrator_Form();
            adminForm.ShowDialog();
            adminForm.Dispose();
        }

        private void storeOwnerFormButton_Click(object sender, EventArgs e)
        {
            StoreOwner_Form storeOwnerForm = new StoreOwner_Form();
            storeOwnerForm.ShowDialog();
            storeOwnerForm.Dispose();
        }
    }
}
