using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    class OfferDiscount : OrderDiscount
    {
        public OfferDiscount(Order order) : base(order)
        {

        }
        public override float getPrice(float discount)
        {
            float num = discount / (float)100;
            return order.getPrice() - (order.getPrice() * num);
        }
    }
}
