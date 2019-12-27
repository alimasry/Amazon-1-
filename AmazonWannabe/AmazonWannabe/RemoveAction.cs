﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class RemoveAction : IAction
    {
        public bool Undo(StoreHistory storeHistory)
        {
            ProductHandler productHandler = new ProductHandler();

            string productId = storeHistory.ProductID;
            string name = storeHistory.ProductName;
            double price = storeHistory.Price;
            int stockNum = storeHistory.StockNum;
            string storeName = storeHistory.StoreName;
            string brandName = storeHistory.BrandName;
            string itemName = storeHistory.ItemName;

            Item item = ItemDBHandler.GetByName(itemName);

            Product product = new Product(productId, name, price, stockNum, storeName, brandName, item);

            if (!productHandler.AddIncognito(product))
                return false;
            StoreHistoryHandler storeHistoryHandler = new StoreHistoryHandler();
            storeHistoryHandler.Delete(storeHistory.Id);

            return true;
        }
    }
}
