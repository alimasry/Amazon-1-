using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class userInfo
    {
        private string email;
        private string password;
        private string l_name;
        private string f_name;
        private string u_name;
        private string phone_number;
        private string country;
        public userInfo(string e,string l,string f,string u,string p,string c,string pass)
        {
            this.email = e;
            this.password = pass;
            this.l_name = l;
            this.f_name = f;
            this.u_name = u;
            this.phone_number = p;
            this.country = c;
        }
        public void setEmail(string e)
        {
            this.email = e;
        }   
        public void setPassword(string pass)
        {
            this.password = pass;
        }
        public void setLastName(string l)
        {
            this.l_name = l;
        }
        public void setFirstName(string f)
        {
            this.f_name = f;
        }
        public void setUserName(string u)
        {
            this.u_name = u;
        } 
        public void setPhone(string p)
        {
            this.phone_number = p;
        }
        public void setCountry(string c)
        {
            this.country = c;
        }
        public string getEmail()
        {
            return this.email;
        }
        public string getPassword()
        {
            return this.password;
        }
        public string getLastName()
        {
            return this.l_name;
        }
        public string getFirstName()
        {
            return this.f_name;
        }
        public string setUserName()
        {
            return this.u_name;
        }
        public string getPhone()
        {
            return this.phone_number;
        }
        public string getCountry()
        {
            return this.country;
        }
    }
}