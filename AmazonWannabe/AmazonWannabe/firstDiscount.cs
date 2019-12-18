using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class firstDiscount : orderDiscount
    {
        public firstDiscount(Order order) : base(order)
        {

        }
        public override float getPrice()
        {
            return order.getPrice()-(order.getPrice()*((float)5/(float)100));
        }
    }
}
