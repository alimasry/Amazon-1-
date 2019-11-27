using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace AmazonWannabe
{
    class Customer
    {
        UserInfo userInfo;

        public Customer (UserInfo userInfo)
        {
            this.userInfo = userInfo;
        }
        public UserInfo getUserInfo()
        {
            return this.userInfo;
        }

        public bool setUserInfo(UserInfo userInfo)
        {
            this.userInfo = userInfo;
            return true;
        }
    }
}
