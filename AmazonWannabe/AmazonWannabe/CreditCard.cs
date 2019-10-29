using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class CreditCard
    {
        private string cardNumber;
        private string CVV;
        public CreditCard(string cn,string cv)
        {
            this.cardNumber = cn;
            this.CVV = cv;
        }
        public void setCardNumber(string cn)
        {
            this.cardNumber = cn;
        }
        public void setCVV(string cv)
        {
            this.CVV = cv;
        }
        public string getCardNumber()
        {
            return this.cardNumber;
        }
        public string getCVV()
        {
            return this.CVV;
        }
    }
}
