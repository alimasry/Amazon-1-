using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class UserInfo
    {
        private string email;
        private string password;
        private string username;
        
        public UserInfo(string e,string u,string pass)
        {
            this.email = e;
            this.password = pass;
            this.username = u;
        }
        public void setEmail(string e)
        {
            this.email = e;
        }   
        public void setPassword(string pass)
        {
            this.password = pass;
        }
        public void setUserName(string u)
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
        public string setUserName()
        {
            return this.username;
        }
    }
}