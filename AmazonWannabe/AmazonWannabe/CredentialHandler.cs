using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    public abstract class CredentialHandler
    {
        private static UserInfo currentUser = null;

        static public bool register(string username, string email, 
            string password, string confirmPassword, string type)
        {
            if (password != confirmPassword)
                return false;
            UserDBHandler userDBHandler = new UserDBHandler();
            UserInfo newUser = new UserInfo(email, username, password, type);
            return userDBHandler.Insert(newUser);
        }

        static public bool login(string email, string password)
        {
            UserDBHandler userDBHandler = new UserDBHandler();
            UserInfo userInfo = new UserInfo(email, null, password, null);
            currentUser = (UserInfo)userDBHandler.Get(userInfo);
            return currentUser != null;
        }

        public static  UserInfo getCurrentUser()
        {
            return currentUser;
        }
    }
}
