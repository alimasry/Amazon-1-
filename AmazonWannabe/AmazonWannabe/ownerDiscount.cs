using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class ownerDiscount : orderDiscount
    {
        public ownerDiscount(Order order) : base(order)
        {

        }
        public override float getPrice()
        {
            return order.getPrice() - (order.getPrice() * ((float)15 / (float)100));
        }
    }
}
