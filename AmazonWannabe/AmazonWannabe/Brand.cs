using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class Brand
    {
        string brandName;
        string brandCategory;

        public Brand(string brandName , string brandCategory)
        {
            this.brandName = brandName;
            this.brandCategory = brandCategory;
        }
        public bool setBrandName(string brandName)
        {
            this.brandName = brandName;
            return true;
        }
        public bool setBrandCategory(string brandCategory)
        {
            this.brandCategory = brandCategory;
            return true;
        }
        public string getBrandName()
        {
            return brandName;
        }
        public string getBrandCategory()
        {
            return brandCategory;
        }
    }
}
