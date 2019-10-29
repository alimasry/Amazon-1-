using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class User
    {
        private UserInfo user_info;
        public void setInfo(UserInfo u)
        {
            this.user_info = u;
        }
        public UserInfo getInfo()
        {
            return this.user_info;
        }
    }
}
