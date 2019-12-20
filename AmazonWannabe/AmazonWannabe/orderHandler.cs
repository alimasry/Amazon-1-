using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    class OrderHandler
    {
        private OrderDBHandler orderDB = new OrderDBHandler();
        public void addOrder(float price, int amount, string address, int ID,float discount)
        {
            float totalPrice = (float)price * (float)amount;
            Int32 totalOrders;
            string type = CredentialHandler.getCurrentUser().getType();
            Order order = new RegularOrder(totalPrice,amount,address,ID);
            MessageBox.Show(order.getPrice().ToString());
            if(type.Equals("Store Owner"))
            {
                order = new OwnerDiscount(order);
                MessageBox.Show(order.getPrice().ToString());
            }
            if (amount >= 2)
            {
                order = new TwoDiscount(order);
                MessageBox.Show(order.getPrice().ToString());
            }
            totalOrders = orderDB.checkTotal(CredentialHandler.getCurrentUser().getEmail());
            if (totalOrders == 0)
            {
                order = new FirstDiscount(order);
                MessageBox.Show("First Order Discount:"+order.getPrice().ToString());
            }
            order = new OfferDiscount(order);
            float finalPrice = order.getPrice(discount);
            MessageBox.Show("Offer Discount:"+finalPrice.ToString());
            orderDB.addOrderDB(finalPrice, amount, address, ID);
            MessageBox.Show("Order successfully added");
        }
    }
}
