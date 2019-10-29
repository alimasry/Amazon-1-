using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class seller : user
    {
        private ArrayList storeList;
        private string bankAccount; 

        public seller(string BA)
        {
            this.bankAccount = BA;
            storeList = new ArrayList();
        }
        public Boolean addProduct()
        {

        }
        public Boolean addStore()
        {

        }
    }
}
