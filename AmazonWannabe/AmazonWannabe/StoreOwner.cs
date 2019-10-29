using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class StoreOwner
    {
        private UserInfo userInfo;

        public StoreOwner(UserInfo userInfo)
        {
            this.userInfo = userInfo;
        }
        public bool addProduct(Product product)
        {
            return true;
        }
        public UserInfo getUserInfo()
        {
            return this.userInfo;
        }
    }
}
