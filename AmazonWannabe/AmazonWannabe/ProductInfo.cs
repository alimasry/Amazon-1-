using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class ProductInfo
    {
        private string id;
        private string storeId;
        private string name;
        private double price;
        //private double rating;
        ProductInfo(string id , string storeId , string name , double price)
        {
            this.id = id;
            this.storeId = storeId;
            this.name = name;
            this.price = price;
        }

        public bool setId(string id)
        {
            this.id = id;
            return true;
        }
        public bool setStoreId(string storeId)
        {
            this.storeId = storeId;
            return true;
        }
        public bool setName(string name)
        {
            this.name = name;
            return true;
        }
        public bool setPrice(double price)
        {
            this.price = price;
            return true;
        }
        public string getId()
        {
            return this.id;
        }
        public string getStoreId()
        {
            return this.storeId;
        }
        public string getName()
        {
            return this.name;
        }
        public double getPrice()
        {
            return price;
        }
    }
}
