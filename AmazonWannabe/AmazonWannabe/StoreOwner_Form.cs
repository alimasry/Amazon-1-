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
        QueryHandler queryHandler = new QueryHandler();
        StoreHistoryHandler historyHandler = new StoreHistoryHandler();

        List<Item> items;
        List<Store> stores;
        List<Brand> brands;
        List<Product> products;
        List<StoreHistory> storeHistories;

        string email = CredentialHandler.getCurrentUser().getEmail();

        public StoreOwner_Form()
        {
            InitializeComponent();
            editor.EditButtons(this);
            items = itemHandler.Get();
            stores = storeHandler.Get(email);
            brands = brandHandler.Get();

            addProductPanel.BringToFront();

            foreach (Item s in items)
            {
                itemBox.Items.Add(s.getItemName());
            }
            foreach(Store s in stores)
            {
                storeBox.Items.Add(s.getStoreName());
                storeBox2.Items.Add(s.getStoreName());
                storeBox3.Items.Add(s.getStoreName());
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
            Product product = new Product("" , nameBox.Text, Convert.ToDouble(priceBox.Text) , Convert.ToInt32(stockNumBox.Text) , store.getStoreName() , brand.getBrandName(), item);

            if(!productHandler.addProduct(product))
            {
                MessageBox.Show("Could not add product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StoreHistory storeHistory = new StoreHistory(storeBox.Text , "Add" , productHandler.GetLatestID() , itemBox.Text , brandBox.Text , Convert.ToInt32(stockNumBox.Text) , Convert.ToDouble(priceBox.Text));
            historyHandler.Add(storeHistory);
            
            MessageBox.Show("Added product successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
        }

        private void addStorePanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string email = CredentialHandler.getCurrentUser().getEmail();
            string name = storeNameBox.Text;
            string type = storeTypeBox.Text;
            string location = storeLocationBox.Text;

            Store store = new Store(email, name, location, type);
            if (!storeHandler.Add(store))
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
        private void ShowPanel(Panel p)
        {
            foreach (Control c in Controls.OfType<Panel>())
            {
                c.Visible = false;
            }
            p.Visible = true;
        }
        private void update_stats()
        { 
            List<object[]> queries = queryHandler.getQueries();

            statsView.Rows.Clear();

            foreach (object[] query in queries) {
                statsView.Rows.Add(query);
            }
            statsView.Refresh();
        }
        private void update_products()
        {
            products = productHandler.GetByStoreName(storeBox2.Text);

            ProductsGridView.Rows.Clear();

            if(products == null)
            {
                MessageBox.Show("Failed to get Products");
                return;
            }

            foreach(Product product in products)
            {
                ProductsGridView.Rows.Add(product.getId() ,
                                          product.getName() ,
                                          product.getPrice() ,
                                          product.getStockNum() ,
                                          product.getItemName() ,
                                          product.getStoreName() ,
                                          product.getBrandName());
            }
        }
        private void update_history()
        {
            storeHistories = historyHandler.Get(storeBox3.Text);

            HistoryGridView.Rows.Clear();

            if (storeHistories == null)
                return;

            foreach(StoreHistory s in storeHistories)
            {
                HistoryGridView.Rows.Add(s.Id,
                                         s.Action,
                                         s.ProductID,
                                         s.StoreName,
                                         s.ItemName,
                                         s.BrandName,
                                         s.StockNum,
                                         s.Price);
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

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            update_products();
        }

        private void ProductViewButton_Click(object sender, EventArgs e)
        {
            ShowPanel(ProductsPanel);
        }

        private void SearchHistoryButton_Click(object sender, EventArgs e)
        {
            update_history();
        }

        private void ViewHistoryButton_Click(object sender, EventArgs e)
        {
            ShowPanel(HistoryPanel);
        }

        private void UndoLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
