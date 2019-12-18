using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class orderDiscount:Order
    {
        protected Order order;
        public orderDiscount(Order order)
        {
            this.order = order;
        }

        public override float getPrice()
        {
            return order.getPrice();
        }

    }
}
