﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class Item
    {
        protected string itemName;
        protected double minPrice;
        protected double maxPrice;

        public Item(string name , double minPrice , double maxPrice)
        {
            this.itemName = name;
            this.minPrice = minPrice;
            this.maxPrice = maxPrice;
        }
        public Item(Item item)
        {
            this.itemName = item.getItemName();
            this.minPrice = item.getMinPrice();
            this.maxPrice = item.getMaxPrice();
        }

        public bool setItemName(string name)
        {
            this.itemName = name;
            return true;
        }
        public bool setBrand(string brand)
        {
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

        public string getItemName()
        {
            return itemName;
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
