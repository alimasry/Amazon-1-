using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class twoDiscount : orderDiscount
    {
        public twoDiscount(Order order) : base(order)
        {

        }
        public override float getPrice()
        {
            return order.getPrice() - (order.getPrice() * ((float)10 / (float)100));
        }
    }
}
