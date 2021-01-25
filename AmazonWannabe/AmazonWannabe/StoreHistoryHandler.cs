using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonWannabe
{
    class StoreHistoryHandler
    {
        public bool Add(StoreHistory storeHistory)
        {
            return StoreHistoryDBHandler.Add(storeHistory);
        }

        public bool Delete(string ID)
        {
            return StoreHistoryDBHandler.Delete(ID);
        }

        public List<StoreHistory> Get(string name)
        {
            return StoreHistoryDBHandler.Get(name);
        }

        public bool UndoChange(StoreHistory storeHistory)
        {
            string actionStr = storeHistory.Action;
            IAction action = null;

            if (actionStr == "Add")
                action = new AddAction();
            else if (actionStr == "Remove")
                action = new RemoveAction();
            else if (actionStr == "Edit")
                action = new EditAction();

            if (action != null)
                return action.Undo(storeHistory);
            return false;
        }

    }
}
