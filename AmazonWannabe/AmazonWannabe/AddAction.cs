using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class AddAction : IAction
    {
        public bool Undo(StoreHistory storeHistory)
        {
            ProductHandler productHandler = new ProductHandler();
            if (!productHandler.DeleteIncognito(storeHistory.ProductID))
                return false;
            StoreHistoryHandler storeHistoryHandler = new StoreHistoryHandler();
            storeHistoryHandler.Delete(storeHistory.Id);

            return true;
        }
    }
}
