using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class OrderDiscount:Order
    {
        protected Order order;
        public OrderDiscount(Order order)
        {
            this.order = order;
        }

        public override float getPrice(float discount=0)
        {
            return order.getPrice();
        }

    }
}
