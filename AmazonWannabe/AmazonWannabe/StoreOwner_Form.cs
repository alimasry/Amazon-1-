using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        BrandHandler brandHandler = new BrandHandler();
        List<Item> items;
        List<Store> stores;
        List<Brand> brands;
        public StoreOwner_Form()
        {
            InitializeComponent();
            editor.EditButtons(this);
            items = itemHandler.getItems();
            stores = storeHandler.getStores();
            brands = brandHandler.getBrands();

            addProductPanel.BringToFront();

            foreach (Item s in items)
            {
                itemBox.Items.Add(s.getItemName());
            }
            foreach(Store s in stores)
            {
                storeBox.Items.Add(s.getStoreName());
            }
            foreach (Brand s in brands)
            {
                brandBox.Items.Add(s.getBrandName());
            }

            statsView.Columns.Add("Name", "Name");
            statsView.Columns.Add("Value", "Value");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Item item = null;
            Store store = null;
            Brand brand = null;

            foreach(Item i in items)
            {
                if (itemBox.Text == i.getItemName())
                    item = i;
            }
            foreach (Store i in stores)
            {
                if (storeBox.Text == i.getStoreName())
                    store = i;
            }
            foreach (Brand i in brands)
            {
                if (brandBox.Text == i.getBrandName())
                    brand = i;
            }
            Product product = new Product("" , nameBox.Text, Convert.ToDouble(priceBox.Text) , 0 , store.getStoreName() , brand.getBrandName(), item);

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
            addStorePanel.Visible = false;
            statsPanel.Visible = false;
            addProductPanel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addStorePanel.Visible = true;
            statsPanel.Visible = false;
            addProductPanel.Visible = false;
        }

        private void userViewsLabel_Click(object sender, EventArgs e)
        {

        }

        private void productSoldLabel_Click(object sender, EventArgs e)
        {

        }

        private void update_stats()
        {
            Form login = Application.OpenForms["Login_Form"];
            UserInfo userInfo = ((Login_Form)login).userInfo;

            QueryHandler queryHandler = new QueryHandler();
            List<object[]> queries = queryHandler.getQueries();

            foreach (object[] query in queries) {
                statsView.Rows.Add(query);
            }
        }

        private void StatsViewButton_Click(object sender, EventArgs e)
        {
            addStorePanel.Visible = false;
            statsPanel.Visible = true;
            addProductPanel.Visible = false;
            statsPanel.BringToFront();
            update_stats();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
