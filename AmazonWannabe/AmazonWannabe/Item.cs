using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class Item
    {
        protected string ItemName;
        protected double minPrice;
        protected double maxPrice;

        public Item(string name , double minPrice , double maxPrice)
        {
            this.ItemName = name;
            this.minPrice = minPrice;
            this.maxPrice = maxPrice;
        }
        public Item(Item item)
        {
            this.ItemName = item.getName();
            this.minPrice = item.getMinPrice();
            this.maxPrice = item.getMaxPrice();
        }

        public bool setName(string name)
        {
            this.ItemName = name;
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

        public string getName()
        {
            return ItemName;
        }
        public double getMinPrice()
        {
            return minPrice; ;
        }
        public double getMaxPrice()
        {
            return maxPrice;
        }
    }
}
