using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class Seller : User
    {
        private ArrayList storeList;
        private string bankAccount; 

        public Seller(string BA)
        {
            this.bankAccount = BA;
            storeList = new ArrayList();
        }
        public Boolean addProduct()
        {
            return true;
        }
        public Boolean addStore()
        {
            return true;
        }
    }
}
