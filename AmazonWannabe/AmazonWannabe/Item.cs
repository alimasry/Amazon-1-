using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class Item
    {
        private string id;
        private string name;
        private string category;
        private double minPrice;
        private double maxPrice;

        Item(string id , string name , string category , double minPrice , double maxPrice)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.minPrice = minPrice;
            this.maxPrice = maxPrice;
        }
        public bool setId(string id)
        {
            this.id = id;
            return true;
        }
        public bool setName(string name)
        {
            this.name = name;
            return true;
        }
        public bool setCategory(string category)
        {
            this.category = category;
            return true;
        }
        public bool setRange(double minPrice , double maxPrice)
        {
            if (minPrice > maxPrice)
                return false;
            this.minPrice = minPrice;
            this.maxPrice = maxPrice;
            return true;
        }

        public string getId()
        {
            return this.id;
        }
        public string getName()
        {
            return this.name;
        }
        public string getCategory()
        {
            return this.category;
        }
        public double getMinPrice()
        {
            return this.minPrice;
        }
        public double getMaxPrice()
        {
            return this.maxPrice;
        }
    }
}
