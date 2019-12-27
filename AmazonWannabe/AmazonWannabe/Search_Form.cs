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
        ProductHandler productHandler = new ProductHandler();
        List<Item> items = new List<Item>();
        OrderHandler order = new OrderHandler();
        Form toolsForm;

        public Search_Form()
        {
            InitializeComponent();
            editor.EditButtons(this);
            Confirm_panel.Visible = false;
            items = ItemDBHandler.Get();
            foreach (Item s in items)
            {
                searchItem.Items.Add(s.getItemName());
            }

            string type = CredentialHandler.getCurrentUser().getType();

            if (type == "Customer")
                toolsButton.Visible = false;
            else if (type == "Administrator")
                toolsForm = new Administrator_Form();
            else if (type == "Store Owner")
                toolsForm = new StoreOwner_Form();
             
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            productsGrid.Rows.Clear();
            List<Product> products = productHandler.GetByName(searchBar.Text);
            foreach(Product p in products)
            {
                DataGridViewRow r = (DataGridViewRow)productsGrid.Rows[0].Clone();
                r.Cells[0].Value = p.getName();
                r.Cells[1].Value = p.getPrice();
                r.Cells[2].Value = p.getId();
                r.Cells[3].Value = p.getOffer();

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
            bool agreed = Agreement.Checked;
             DataGridViewRow selectedRow = productsGrid.CurrentRow;
            string productID = Convert.ToString(selectedRow.Cells[2].Value);
            int ID = int.Parse(productID);
            if (!Agreement.Checked)
            {
                MessageBox.Show("please select the checkbox to confirm");
            }
            if (amountBox.Text == "" || addressBox.Text == "")
            {
                MessageBox.Show("please enter amount and address");
            }
            else
            {
                int amount = Int32.Parse(amountBox.Text);
                string priceString = Convert.ToString(selectedRow.Cells[1].Value);
                float price = float.Parse(priceString);
                string address = addressBox.Text;
                float discount= float.Parse(Convert.ToString(selectedRow.Cells[3].Value));
                productHandler.check(amount,ID,price,address,discount);
            }

        }

        private void AdminFormButton_Click(object sender, EventArgs e)
        {
            toolsForm.ShowDialog();
            toolsForm.Dispose();
        }

        private void storeOwnerFormButton_Click(object sender, EventArgs e)
        {
            StoreOwner_Form storeOwnerForm = new StoreOwner_Form();
            storeOwnerForm.ShowDialog();
            storeOwnerForm.Dispose();
        }
    }
}
