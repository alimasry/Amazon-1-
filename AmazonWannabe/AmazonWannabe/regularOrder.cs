using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class regularOrder : Order
    {
        public regularOrder(float price, int amount,string address,int ID)
        {
            this.price = price;
            this.amount = amount;
            this.address = address;
            this.ID = ID;
        }
        public override float getPrice()
        {
            return this.price;
        }
        public int getAmount()
        {
            return this.amount;
        }
        public int getID()
        {
            return this.ID;
        }
        public string getAddress()
        {
            return this.address;
        }
    }
}
