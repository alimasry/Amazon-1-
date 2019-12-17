using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    class CustomerHandler
    {

        customerDBHandler customerDB = new customerDBHandler();
        public void addOrder(float totalPrice,int amount,string address,int ID)
        {
            customerDB.addOrderDB(totalPrice, amount, address, ID);
        }
    }
}
