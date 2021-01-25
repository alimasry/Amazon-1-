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
    public partial class Edit_Product : Form
    {
        Product product;

        ProductHandler productHandler = new ProductHandler();

        List<Item> items;
        List<Store> stores;
        List<Brand> brands;

        string email = CredentialHandler.getCurrentUser().getEmail();

        public Edit_Product(Product product)
        {
            InitializeComponent();

            this.product = product;
            NameBox.Text = product.getName();
            PriceBox.Text = product.getPrice().ToString();
            StockNumBox.Text = product.getStockNum().ToString();

            items = ItemDBHandler.Get();
            stores = StoreDBHandler.Get(email);
            brands = BrandDBHandler.Get();

            foreach (Item s in items)
            {
                ItemBox.Items.Add(s.getItemName());
            }

            foreach (Store s in stores)
            {
                StoreBox.Items.Add(s.getStoreName());
            }

            foreach (Brand s in brands)
            {
                BrandBox.Items.Add(s.getBrandName());
            }

            ItemBox.Text = product.getItemName();
            StoreBox.Text = product.getStoreName();
            BrandBox.Text = product.getBrandName();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string id = product.getId();
            string name = NameBox.Text;
            double price = Convert.ToDouble(PriceBox.Text);
            int stockNum = Convert.ToInt32(StockNumBox.Text);
            string storeName = StoreBox.Text;
            string brandName = BrandBox.Text;

            Item item = null;
            foreach(Item i in items)
            {
                if (ItemBox.Text == i.getItemName())
                {
                    item = i;
                    break;
                }
            }

            product = new Product(id, name, price, stockNum, storeName, brandName, item);

            if(!productHandler.Update(product))
            {
                MessageBox.Show("Failed to save");
                return;
            }

            this.Close();
        }
    }
}
