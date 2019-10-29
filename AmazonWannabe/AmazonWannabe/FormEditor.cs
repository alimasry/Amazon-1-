using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AmazonWannabe
{
    class FormEditor
    {
        
        public void ClearRecords(DataGridView Grid)
        {
            while (Grid.Rows.Count > 0)
            {
                Grid.Rows.Remove(Grid.Rows[0]);
            }
        }

        public void EditButtons(Control parent)
        {
            foreach (Button c in parent.Controls.OfType<Button>())
            {
                c.FlatAppearance.BorderColor = Color.White;
            }
        }

        public bool CheckTextBoxes(Control parent)
        {
            foreach (TextBox c in parent.Controls.OfType<TextBox>())
            {
                if (!c.Enabled)
                    continue;
                if (c.Text == "" && c.Enabled)
                    return false;
                bool allSpaces = true;
                foreach(char ch in c.Text)
                    if(ch != ' ')
                    {
                        allSpaces = false;
                        break;
                    }
                if (allSpaces)
                    return false;
            }
            return true;
        }

        public bool CheckPasswordValidity(string pass)
        {
            foreach(char c in pass)
            {
                if ((c < 'A' || c > 'Z') && (c < 'a' || c > 'z') && c != '_' && (c < '0' || c > '9'))
                    return false;
            }
            return true;
        }
    }
}
