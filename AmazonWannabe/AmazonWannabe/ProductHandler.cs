﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    class ProductHandler
    {

        ProductDBHandler productDBHandler = new ProductDBHandler();
        OrderHandler orderHandler = new OrderHandler();
        StoreHistoryHandler storeHistoryHandler = new StoreHistoryHandler();
        public bool AddIncognito(Product product)
        {
            if (product.getPrice() > product.getMaxPrice() || product.getPrice() < product.getMinPrice())
                return false;
            return productDBHandler.Add(product);
        }
        public bool Add(Product product)
        {
            if (product.getPrice() > product.getMaxPrice() || product.getPrice() < product.getMinPrice())
                return false;

            if(!productDBHandler.Add(product))
            {
                return false;
            }

            string name = product.getName().Replace("'", "''");
            double price = product.getPrice();
            string itemName = product.getItemName().Replace("'", "''");
            string store = product.getStoreName().Replace("'", "''");
            string brand = product.getBrandName().Replace("'", "''");
            int stockNum = product.getStockNum();

            storeHistoryHandler = new StoreHistoryHandler();
            StoreHistory storeHistory = new StoreHistory(null, store, name, "Add", GetLatestID(), itemName, brand, stockNum, price);
            storeHistoryHandler.Add(storeHistory);

            return true;
        }

        public List<Product> GetByName(string name)
        {
            return productDBHandler.GetByName(name);
        }
        public List<Product> GetByStoreName(string storeName)
        {
            return productDBHandler.GetByStoreName(storeName);
        }
        public Product GetByID(string id)
        {
            return productDBHandler.GetByID(id);
        }
        public List<Product> Get()
        {
            return productDBHandler.Get();
        }
        public string GetLatestID()
        {
            return productDBHandler.GetLatestID();
        }
        public bool DeleteIncognito(string productId)
        {
            return productDBHandler.Delete(productId);
        }
        public bool Delete(string productId)
        {
            Product oldProduct = GetByID(productId);

            string name = oldProduct.getName().Replace("'", "''");
            double price = oldProduct.getPrice();
            string itemName = oldProduct.getItemName().Replace("'", "''");
            string storeName = oldProduct.getStoreName().Replace("'", "''");
            string brandName = oldProduct.getBrandName().Replace("'", "''");
            int stockNum = oldProduct.getStockNum();

            StoreHistoryHandler storeHistoryHandler = new StoreHistoryHandler();
            StoreHistory storeHistory = new StoreHistory(null, storeName, name, "Remove", productId, itemName, brandName, stockNum, price);
            storeHistoryHandler.Add(storeHistory);

            return productDBHandler.Delete(productId);
        }
        public bool UpdateIncognito(Product product)
        {
            return productDBHandler.Update(product);
        }
        public bool Update(Product product)
        {
            Product oldProduct = GetByID(product.getId());

            string name = oldProduct.getName().Replace("'", "''");
            double price = oldProduct.getPrice();
            string itemName = oldProduct.getItemName().Replace("'", "''");
            string storeName = oldProduct.getStoreName().Replace("'", "''");
            string brandName = oldProduct.getBrandName().Replace("'", "''");
            int stockNum = oldProduct.getStockNum();

            StoreHistoryHandler storeHistoryHandler = new StoreHistoryHandler();
            StoreHistory storeHistory = new StoreHistory(null, storeName, name, "Edit", product.getId(), itemName, brandName, stockNum, price);
            storeHistoryHandler.Add(storeHistory);

            return productDBHandler.Update(product);
        }

        public int checkStock(int amount,int ID)
        {
            int updated = productDBHandler.checkStock(ID);

            if (updated >= amount)
            {
                updated = updated - amount;
            }
            else
            {
                updated = 0;
            }
            return updated;
        }
        public void check(int amount, int ID, float price, string address,float discount)
        {
            int updated = checkStock(amount, ID);
            if (updated > 0)
            {
                productDBHandler.updateStock(updated, ID);
                orderHandler.addOrder(price, amount, address, ID,discount);
            }
        }
        public void updateOffer(int ID,int Percentage)
        {
            productDBHandler.updateDBOffer(ID,Percentage);
        }
    }
}
