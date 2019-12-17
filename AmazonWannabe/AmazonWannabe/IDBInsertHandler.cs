using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    interface IDBInsertHandler
    {
        bool Insert(Object obj);
    }
}
