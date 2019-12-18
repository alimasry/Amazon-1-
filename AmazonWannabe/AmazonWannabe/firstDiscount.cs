using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class FirstDiscount : OrderDiscount
    {
        public FirstDiscount(Order order) : base(order)
        {

        }
        public override float getPrice()
        {
            return order.getPrice()-(order.getPrice()*((float)5/(float)100));
        }
    }
}
