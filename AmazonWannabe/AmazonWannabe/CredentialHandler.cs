using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    public static class CredentialHandler
    {
        private static UserInfo currentUser = null;

        static public bool register(string username, string email, 
            string password, string confirmPassword, string type)
        {
            if (password != confirmPassword)
                return false;
            
            UserInfo newUser = new UserInfo(email, username, password, type);
            return UserDBHandler.Add(newUser);
        }

        static public bool login(string email, string password)
        {
            UserInfo userInfo = new UserInfo(email, null, password, null);
            currentUser = (UserInfo)UserDBHandler.Get(userInfo);
            return currentUser != null;
        }

        public static  UserInfo getCurrentUser()
        {
            return currentUser;
        }
    }
}
