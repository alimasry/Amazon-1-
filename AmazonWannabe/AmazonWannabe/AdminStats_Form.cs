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
    public partial class AdminStats_Form : Form
    {
        public AdminStats_Form()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addQuery(queryName.Text, queryType.Text, queryField.Text);
        }

        void addQuery(string name, string type, string field)
        {
            if (name == "" || type == "" || field == "")
            {
                MessageBox.Show("Cannot Add Query.");
                return;
            }

            if (QueryDBHandler.addQuery(name, type, field))
                MessageBox.Show("Query Added Successfully.");
            else
                MessageBox.Show("Cannot Add Query.");

        }
    }
}
