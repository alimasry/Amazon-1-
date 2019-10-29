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
        //private double rating;
        public Product(string id , string name , double price , Item item):base(item)
        {
            this.ProductId = id;
            this.ProductName = name;
            this.price = price;
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
    }
}
