using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    interface IDBHandler
    {
        bool Insert(Object obj);
        bool Remove(Object obj);
    }
}
