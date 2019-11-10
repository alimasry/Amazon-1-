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
        protected string itemBrand;
        protected double minPrice;
        protected double maxPrice;

        public Item(string name , string brand , double minPrice , double maxPrice)
        {
            this.itemName = name;
            this.itemBrand = brand;
            this.minPrice = minPrice;
            this.maxPrice = maxPrice;
        }
        public Item(Item item)
        {
            this.itemName = item.getName();
            this.itemBrand = item.getBrand();
            this.minPrice = item.getMinPrice();
            this.maxPrice = item.getMaxPrice();
        }

        public bool setName(string name)
        {
            this.itemName = name;
            return true;
        }
        public bool setBrand(string brand)
        {
            this.itemBrand = brand;
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
            return itemName;
        }
        public string getBrand()
        {
            return itemBrand;
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
