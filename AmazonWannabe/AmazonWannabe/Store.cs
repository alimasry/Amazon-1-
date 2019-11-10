using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class Store
    {
        string email;
        int soldNum;
        string approved;
        string storeName;
        string storeLocation;
        string storeType;

        public Store(string email , string storeName , string storeLocation , string type)
        {
            this.email = email;
            this.soldNum = 0;
            this.approved = "0";
            this.storeName = storeName;
            this.storeLocation = storeLocation;
            this.storeType = type;
        }

        public Store(string email , int soldNum , string approved , string storeName, string storeLocation, string type)
        {
            this.email = email;
            this.soldNum = soldNum;
            this.approved = approved;
            this.storeName = storeName;
            this.storeLocation = storeLocation;
            this.storeType = type;
        }

        public bool setEmail(string email)
        {
            this.email = email;
            return true;
        }
        public bool setSoldNum(int soldNum)
        {
            this.soldNum = soldNum;
            return true;
        }
        public bool setStoreName(string storeName)
        {
            this.storeName = storeName;
            return true;
        }
        public bool setStoreLocation(string storeLocation)
        {
            this.storeLocation = storeLocation;
            return true;
        }
        public bool setStoreType(string storeType)
        {
            this.storeType = storeType;
            return true;
        }
        public string getEmail()
        {
            return email;
        }
        public int getSoldNum()
        {
            return soldNum;
        }
        public string getApproved()
        {
            return approved;
        }
        public string getStoreName()
        {
            return storeName;
        }
        public string getStoreLocation()
        {
            return storeLocation;
        }
        public string getStoreType()
        {
            return storeType;
        }
    }
}
