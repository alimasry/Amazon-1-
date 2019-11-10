using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Item item = new Item(nameBox.Text  , Convert.ToDouble(minPriceBox.Text) , Convert.ToDouble(maxPriceBox.Text));
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

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter adapter;
            DataSet ds = new DataSet();
            SQLiteConnection connection = new SQLiteConnection(Login_Form.connectionString);
            connection.Open();
            string SQLquery = "SELECT * FROM Store Where Approved=0";
            using (SQLiteCommand SQLcommand = new SQLiteCommand(SQLquery, connection))
            {
                try
                {
                    adapter = new SQLiteDataAdapter(SQLcommand);
                    adapter.Fill(ds);
                    StoresGridView.DataSource = ds.Tables[0];
                    panel1.BringToFront();
                    panel1.Visible =true ;
                }
                catch (SQLiteException)
                {
                    MessageBox.Show("Error");
                    connection.Close();
                    return;
                }
            }
            connection.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Approve_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = StoresGridView.CurrentRow;
            string StoreName = Convert.ToString(selectedRow.Cells[0].Value);
            SQLiteConnection connection = new SQLiteConnection(Login_Form.connectionString);
            connection.Open();
            string SQLquery = "UPDATE Store SET Approved=1 where Name='" + StoreName +"'" ;
            if (StoreName != null)
            {
                using (SQLiteCommand SQLcommand = new SQLiteCommand(SQLquery, connection))
                {
                    try
                    {
                        SQLcommand.ExecuteNonQuery();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show(ex.Message);
                        connection.Close();
                        return;
                    }
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Please select a specific row");
                connection.Close();
            }
        }

        private void closeButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string brandName = Name_box.Text;
            string brandCategory = Category_box.Text;
            SQLiteConnection connection = new SQLiteConnection(Login_Form.connectionString);
            connection.Open();
            string SQLquery = "INSERT INTO [Brand](Name,Category) VALUES ('" + brandName + "','" + brandCategory + "')";
            using (SQLiteCommand SQLcommand = new SQLiteCommand(SQLquery, connection))
            {
                try
                {
                    SQLcommand.ExecuteNonQuery();
                }
                catch (SQLiteException)
                {
                    MessageBox.Show("Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    return;
                }
            }
        }
        private void Add_Brand_Click_1(object sender, EventArgs e)
        {
            panel2.BringToFront();
            panel2.Visible = true;

        }
    }
}
