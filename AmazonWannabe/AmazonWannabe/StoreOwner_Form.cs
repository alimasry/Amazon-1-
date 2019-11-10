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
        StoreHandler storeHandler = new StoreHandler();
        List<Item> items;
        List<Store> stores;
        public StoreOwner_Form()
        {
            InitializeComponent();
            editor.EditButtons(this);
            items = itemHandler.getItems();
            stores = storeHandler.getStores();

            foreach (Item s in items)
            {
                itemBox.Items.Add(s.getName());
            }
            foreach(Store s in stores)
            {
                storeBox.Items.Add(s.getStoreName());
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Item item = null;
            Store store = null;

            foreach(Item i in items)
            {
                if (itemBox.Text == i.getName())
                    item = i;
            }
            foreach (Store i in stores)
            {
                if (storeBox.Text == i.getStoreName())
                    store = i;
            }
            Product product = new Product("" , nameBox.Text, Convert.ToDouble(priceBox.Text), store.getStoreName(), item);

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

        private void addStorePanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form login = Application.OpenForms["Login_Form"];
            string email = ((Login_Form)login).userInfo.getEmail();
            string name = storeNameBox.Text;
            string type = storeTypeBox.Text;
            string location = storeLocationBox.Text;

            Store store = new Store(email, name, location, type);
            if (!storeHandler.addStore(store))
            {
                MessageBox.Show("Could not add store.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProductPanel.Visible = true;
            addStorePanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addProductPanel.Visible = false;
            addStorePanel.Visible = true;
        }
    }
}
