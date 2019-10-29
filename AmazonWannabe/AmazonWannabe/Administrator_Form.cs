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
        FormEditor editor = new FormEditor();
        public Administrator_Form()
        {
            InitializeComponent();
            editor.EditButtons(this);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Item item = new Item("" , nameBox.Text , Convert.ToDouble(minPriceBox.Text) , Convert.ToDouble(maxPriceBox.Text));
        }
    }
}
