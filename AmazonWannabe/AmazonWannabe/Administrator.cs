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

        public UserInfo getUserInfo()
        {
            return this.userInfo;
        }

        public bool AddItem(Item item)
        {
            if (item == null || item.getMinPrice() > item.getMaxPrice())
                return false;

            if (!ItemDBHandler.Add(item))
                return false;


            return true;
        }
        public bool AddBrand(Brand brand)
        {
            if (brand == null || brand.getBrandName() == "" || brand.getBrandCategory() == "")
                return false;

            if (!BrandDBHandler.Add(brand))
                return false;

            return true;
        }
    }
}
