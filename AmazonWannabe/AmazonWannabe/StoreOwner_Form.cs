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
        public StoreOwner_Form()
        {
            InitializeComponent();
            editor.EditButtons(this);
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search_Form form = new Search_Form();
            form.ShowDialog();
            form.Dispose();
        }
    }
}
