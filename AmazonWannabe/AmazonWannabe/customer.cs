using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class customer : user
    {
        private ArrayList creditCards;
        private ArrayList addresses;
        public customer()
        {
            this.creditCards = new ArrayList();
            this.addresses = new ArrayList();
        }
        public void  addCreditCard(CreditCard cc)
        {

        }
        public void addAdress(string ad)
        {

        }
    }
}
