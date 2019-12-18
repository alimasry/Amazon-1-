using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    public abstract class Order
    {
        protected float price;
        protected int amount;
        protected string address;
        protected int ID;
        public abstract float getPrice();
    }
}
