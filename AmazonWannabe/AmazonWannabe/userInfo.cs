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
        
        public UserInfo()
        {

        }
        public UserInfo(string email,string username,string password, string type)
        {
            this.email = email;
            this.password = password;
            this.username = username;
            this.type = type;
        }

        public void setType(string t)
        {
            this.type = t;
        }
        public void setEmail(string e)
        {
            this.email = e;
        }   
        public void setPassword(string pass)
        {
            this.password = pass;
        }
        public void setUsername(string u)
        {
            this.username = u;
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