using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    class StoreHistoryHandler
    {
        StoreHistoryDBHandler handler = new StoreHistoryDBHandler();
        public bool Add(StoreHistory storeHistory)
        {
            return handler.Add(storeHistory);
        }

        public bool Delete(string ID)
        {
            return handler.Delete(ID);
        }

        public List<StoreHistory> Get(string name)
        {
            return handler.Get(name);
        }

        public bool UndoChange(StoreHistory storeHistory)
        {
            string action = storeHistory.Action;

            if (action == "Add")
            {
                ProductHandler productHandler = new ProductHandler();
                productHandler.Delete(storeHistory.ProductID);
            }
            else if(action == "Remove")
            {
                ProductHandler productHandler = new ProductHandler();

                string productId = storeHistory.ProductID;
                string name = storeHistory.ProductName;
                double price = storeHistory.Price;
                int stockNum = storeHistory.StockNum;
                string storeName = storeHistory.StoreName;
                string brandName = storeHistory.BrandName;
                string itemName = storeHistory.ItemName;

                ItemHandler itemHandler = new ItemHandler();
                Item item = itemHandler.GetByName(itemName);

                Product product = new Product(productId, name, price, stockNum, storeName, brandName, item);

                productHandler.Add(product);
            }
            else if(action == "Update")
            {
                ProductHandler productHandler = new ProductHandler();

                string productId = storeHistory.ProductID;
                string name = storeHistory.ProductName;
                double price = storeHistory.Price;
                int stockNum = storeHistory.StockNum;
                string storeName = storeHistory.StoreName;
                string brandName = storeHistory.BrandName;
                string itemName = storeHistory.ItemName;

                ItemHandler itemHandler = new ItemHandler();
                Item item = itemHandler.GetByName(itemName);

                Product product = new Product(productId, name, price, stockNum, storeName, brandName, item);

                productHandler.Update(product);
            }
            else
            {
                return false;
            }
            handler.Delete(storeHistory.Id);

            return true;
        }

    }
}
