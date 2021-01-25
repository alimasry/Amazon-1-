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

        public static bool isCollaborator(string email)
        {
            return CollaboratorDBHandler.isCollaborator(email);
        }

        public static bool Add(string email, string storeName)
        {
            email = email.Replace("'", "''");
            storeName = storeName.Replace("'", "''");
            return CollaboratorDBHandler.Add(email, storeName);
        }
    }
}
