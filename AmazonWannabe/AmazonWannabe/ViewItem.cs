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
    public partial class ViewItem : Form
    {
        private StoreHandler storeHandler = new StoreHandler();
        private Product product;
        public ViewItem(Product product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void ViewItem_Load(object sender, EventArgs e)
        {
            ProductName.Text = product.getName();
            ProductPrice.Text = product.getPrice().ToString();
            StoreName.Text = product.getStoreName();
            storeHandler.addUserView(product.getStoreName());
        }
    }
}
