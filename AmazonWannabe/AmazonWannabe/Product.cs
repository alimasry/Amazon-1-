using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class Product : Item
    {
        private string ProductId;
        private string ProductName;
        private double price;
        private string storeName;
        //private double rating;
        public Product(string id , string name , double price , string storeName , Item item):base(item)
        {
            this.ProductId = id;
            this.ProductName = name;
            this.price = price;
            this.storeName = storeName;
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
        public bool setStoreName(string storeName)
        {
            this.storeName = storeName;
            return true;
        }
        public string getId()
        {
            return this.ProductId;
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
    }
}
