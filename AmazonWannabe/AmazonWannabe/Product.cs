using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    public class Product : Item
    {
        private string ProductId;
        private string ProductName;
        private double price;
        private string storeName;
        private int stockNum;
        private string brandName;
        private int Offer;
        
        public Product(string id , string name , double price , int stockNum , string storeName , string brandName , Item item,int Offer=0):base(item)
        {
            this.ProductId = id;
            this.ProductName = name;
            this.price = price;
            this.stockNum = stockNum;
            this.storeName = storeName;
            this.brandName = brandName;
            this.Offer = Offer;
        }

        public int getOffer()
        {
            return this.Offer;
        }
        public Product(string name , double price , string storeName , string brandName , Item item):base(item)
        {
            this.ProductId = null;
            this.ProductName = name;
            this.price = price;
            this.stockNum = 0;
            this.storeName = storeName;
            this.brandName = brandName;
        }
        public Product(Product product , Item item):base(item)
        {
            this.ProductId = product.getId();
            this.ProductName = product.getName();
            this.price = product.getPrice();
            this.stockNum = product.getStockNum();
            this.storeName = product.getStoreName();
            this.brandName = product.getBrandName();
        }

        public bool setId(string id)
        {
            this.ProductId = id;
            return true;
        }
        
        public bool setName(string name)
        {
            this.ProductName = name;
            return true;
        }
        public bool setPrice(double price)
        {
            this.price = price;
            return true;
        }
        public bool setStockNum(int stockNum)
        {
            this.stockNum = stockNum;
            return true;
        }
        public bool setStoreName(string storeName)
        {
            this.storeName = storeName;
            return true;
        }
        public bool setBrandName(string brandName)
        {
            this.brandName = brandName;
            return true;
        }
        public string getId()
        {
            return this.ProductId;
        }
        public int getStockNum()
        {
            return this.stockNum;
        }
        public string getName()
        {
            return this.ProductName;
        }
        public double getPrice()
        {
            return price;
        }
        public string getStoreName()
        {
            return storeName;
        }
        public string getBrandName()
        {
            return brandName;
        }
    }
}
