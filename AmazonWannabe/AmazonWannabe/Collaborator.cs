using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    public class Collaborator
    {
        string email;
        string storeName;

        Collaborator(string email, string storeName)
        {
            this.email = email;
            this.storeName = storeName;
        }

        public static void Add(string email, string storeName)
        {
            email = email.Replace("'", "''");
            storeName = storeName.Replace("'", "''");
            if (CollaboratorDBHandler.Add(email, storeName))
                MessageBox.Show("Collaborator Added Successfuly.");
            else
                MessageBox.Show("Coudn't Add Collaborator.");
        }
    }
}
