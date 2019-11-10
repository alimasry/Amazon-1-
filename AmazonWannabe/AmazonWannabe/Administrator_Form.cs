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
    public partial class Administrator_Form : Form
    {
        ItemHandler itemHandler = new ItemHandler();
        FormEditor editor = new FormEditor();
        public Administrator_Form()
        {
            InitializeComponent();
            editor.EditButtons(this);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Item item = new Item(nameBox.Text , brandBox.Text , Convert.ToDouble(minPriceBox.Text) , Convert.ToDouble(maxPriceBox.Text));
            if(!itemHandler.addItem(item))
            {
                MessageBox.Show("Could not create item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Item created successfully.", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search_Form form = new Search_Form();
            form.ShowDialog();
            form.Dispose();
        }
    }
}
