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
    public partial class StoreOwner_Form : Form
    {
        FormEditor editor = new FormEditor();
        ProductHandler productHandler = new ProductHandler();
        ItemHandler itemHandler = new ItemHandler();
        List<Item> items;
        public StoreOwner_Form()
        {
            InitializeComponent();
            editor.EditButtons(this);
            items = itemHandler.getItems();

            foreach (Item s in items)
            {
                itemBox.Items.Add(s.getItemName());
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Item item = null;
            foreach(Item i in items)
            {
                if (itemBox.Text == i.getItemName())
                    item = i;
            }
            Product product = new Product("", nameBox.Text, Convert.ToDouble(priceBox.Text), item);

            if(!productHandler.addProduct(product))
            {
                MessageBox.Show("Could not add product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Added product successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search_Form form = new Search_Form();
            form.ShowDialog();
            form.Dispose();
        }
    }
}
