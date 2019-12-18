using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    class orderHandler
    {
        private orderDBHandler orderDB = new orderDBHandler();
        public void addOrder(float price, int amount, string address, int ID)
        {
            float totalPrice = (float)price * (float)amount;
            Int32 totalOrders;
            string type = CredentialHandler.getCurrentUser().getType();
            Order order = new regularOrder(totalPrice,amount,address,ID);
            MessageBox.Show(order.getPrice().ToString());
            if(type.Equals("Store Owner"))
            {
                order = new ownerDiscount(order);
                MessageBox.Show(order.getPrice().ToString());
            }
            if (amount >= 2)
            {
                order = new twoDiscount(order);
                MessageBox.Show(order.getPrice().ToString());
            }
            totalOrders = orderDB.checkTotal(CredentialHandler.getCurrentUser().getEmail());
            if (totalOrders == 0)
            {
                order = new firstDiscount(order);
                MessageBox.Show(order.getPrice().ToString());
            }
            orderDB.addOrderDB(order.getPrice(), amount, address, ID);
            MessageBox.Show("Order successfully added");
        }
    }
}
