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
            items = ItemDBHandler.Get();
            stores = StoreDBHandler.Get(email);
            brands = BrandDBHandler.Get();

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

            if(!productHandler.Add(product))
            {
                MessageBox.Show("Could not add product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
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
            if (!StoreDBHandler.Add(store))
            {
                MessageBox.Show("Could not add store.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPanel(addProductPanel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowPanel(addStorePanel);
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
            List<object[]> queries = Query.Get();

            statsView.Rows.Clear();

            foreach (object[] query in queries)
                statsView.Rows.Add(query);

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
                                          product.getBrandName(),
                                          product.getOffer());
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
                                         s.ProductName,
                                         s.ProductID,
                                         s.StoreName,
                                         s.ItemName,
                                         s.BrandName,
                                         s.StockNum,
                                         s.Price);
            }
        }
        private void UpdateLists()
        {
            update_history();
            update_products();
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
            ProductsGridView.Rows.Clear();
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
            if(HistoryGridView.SelectedCells.Count > 0)
            {
                DataGridViewRow row = HistoryGridView.CurrentRow;
                string action = row.Cells[1].Value.ToString();
                string productID = row.Cells[3].Value.ToString();
                //MessageBox.Show(row.Cells[0].Value.ToString());
                string id = row.Cells[0].Value.ToString();
                string storeName = row.Cells[4].Value.ToString();
                string itemName = row.Cells[5].Value.ToString();
                string brandName = row.Cells[6].Value.ToString();
                int stockNum = Convert.ToInt32(row.Cells[7].Value.ToString());
                string productName = row.Cells[2].Value.ToString();
                double price = Convert.ToDouble(row.Cells[8].Value.ToString());

                StoreHistory storeHistory = new StoreHistory(id, storeName, productName, action, productID, itemName, brandName, stockNum, price);
                
                if(!historyHandler.UndoChange(storeHistory))
                {
                    MessageBox.Show("Failed to undo change");
                }

                UpdateLists();
            }
        }

        private void EditLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ProductsGridView.SelectedCells.Count > 0)
            {
                DataGridViewRow row = ProductsGridView.CurrentRow;
                string name = row.Cells[1].Value.ToString();
                int stockNum = Convert.ToInt32(row.Cells[3].Value.ToString());
                string id = row.Cells[0].Value.ToString();
                string itemName = row.Cells[4].Value.ToString();
                string storeName = row.Cells[5].Value.ToString();
                string brandName = row.Cells[6].Value.ToString();
                double price = Convert.ToDouble(row.Cells[2].Value.ToString());
                Item item = null;
                foreach (Item i in items)
                {
                    if (itemName == i.getItemName())
                    {
                        item = i;
                        break;
                    }
                }

                Product product = new Product(id, name, price, stockNum, storeName, brandName, item);
                //product.getItemName();
                //MessageBox.Show("1");
                Edit_Product form = new Edit_Product(product);
                form.ShowDialog();

                UpdateLists();
            }
        }

        private void RemoveLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataGridViewRow row = ProductsGridView.CurrentRow;
            if(!productHandler.Delete(row.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Failed to delete Product");
            }

            UpdateLists();
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = ProductsGridView.CurrentRow;
            if (selectedRow == null)
                return;
            string productID = Convert.ToString(selectedRow.Cells[0].Value);
            int ID = int.Parse(productID);
            int percentage = Int32.Parse(offerBox.Text);
            if (percentage < 0 || percentage > 100)
            {
                MessageBox.Show("Please Enter a suitable percentage");
            }
            else { 
                productHandler.updateOffer(ID, percentage);
            }
        }

        private void addCollabButton_Click(object sender, EventArgs e)
        {
            AddCollaborator_Form addForm = new AddCollaborator_Form();
            addForm.ShowDialog();
            addForm.Dispose();
        }
    }
}
