using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class Administrator
    {
        UserInfo userInfo;

        public Administrator (UserInfo userInfo)
        {
            this.userInfo = userInfo;
        }
        public bool addSellerUser(UserInfo u)
        {
            return true;
        }
        public bool addProduct(Product i)
        {
            return true;
        }

        public UserInfo getUserInfo()
        {
            return this.userInfo;
        }
        public bool addItem(Product item)
        {
            if (item == null || item.getMinPrice() > item.getMaxPrice())
                return false;

            ItemHandler itemHandler = new ItemHandler();
            if (!itemHandler.addItem(item))
                return false;


            return true;
        }
    }
}
