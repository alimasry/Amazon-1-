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
    public partial class Search_Form : Form
    {
        FormEditor editor = new FormEditor();
        ItemHandler itemHandler = new ItemHandler();
        ProductHandler productHandler = new ProductHandler();
        List<Item> items = new List<Item>();
        public Search_Form()
        {
            InitializeComponent();
            editor.EditButtons(this);

            items = itemHandler.getItems();
            foreach (Item s in items)
            {
                searchItem.Items.Add(s.getItemName());
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<Product> products = productHandler.getProducts();
            foreach(Product p in products)
            {
                DataGridViewRow r = (DataGridViewRow)productsGrid.Rows[0].Clone();
                r.Cells[0].Value = p.getName();
                r.Cells[1].Value = p.getPrice();
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
            List<Product> products = productHandler.getProducts();

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
    }
}
