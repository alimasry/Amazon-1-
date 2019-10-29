using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class Product
    {
        private ProductInfo productInfo;

        Product(ProductInfo productInfo)
        {
            this.productInfo = productInfo; 
        }

        public bool setProductInfo(ProductInfo productInfo)
        {
            this.productInfo = productInfo;
            return true;
        }

        public ProductInfo getProductInfo()
        {
            return this.productInfo;
        }
    }
}
