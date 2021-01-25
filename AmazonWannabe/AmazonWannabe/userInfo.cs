using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    public class UserInfo
    {
        private string email;
        private string password;
        private string username;
        private string type;
        
        public UserInfo(string email,string username,string password, string type)
        {
            this.email = email;
            this.password = password;
            this.username = username;
            this.type = type;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }   

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }
        
        public string getEmail()
        {
            return this.email;
        }

        public string getPassword()
        {
            return this.password;
        }

        public string getUsername()
        {
            return this.username;
        }

        public string getType()
        {
            return this.type;
        }
    }
}