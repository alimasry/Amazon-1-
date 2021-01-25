using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class StoreHistory
    {
        string id;
        string storeName;
        string productName;
        string action;
        string productID;
        string itemName;
        string brandName;
        int stockNum;
        double price;

        public StoreHistory(string id , string storeName , string productName , string action , string productID , string itemName=null , string brandName=null , int stockNum=0 , double price=0)
        {
            this.id = id;
            this.storeName = storeName;
            this.productName = productName;
            this.action = action;
            this.productID = productID;
            this.itemName = itemName;
            this.brandName = brandName;
            this.stockNum = stockNum;
            this.price = price;
        }
        public string StoreName { get => storeName; set => storeName = value; }
        public string Action { get => action; set => action = value; }
        public string ProductID { get => productID; set => productID = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public string BrandName { get => brandName; set => brandName = value; }
        public int StockNum { get => stockNum; set => stockNum = value; }
        public double Price { get => price; set => price = value; }
        public string Id { get => id; set => id = value; }
        public string ProductName { get => productName; set => productName = value; }
    }
}
