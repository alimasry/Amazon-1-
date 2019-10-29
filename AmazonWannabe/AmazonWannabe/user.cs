using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class user
    {
        private userInfo user_info;
        public void setInfo(userInfo u)
        {
            this.user_info = u;
        }
        public userInfo getInfo()
        {
            return this.user_info;
        }
    }
}
