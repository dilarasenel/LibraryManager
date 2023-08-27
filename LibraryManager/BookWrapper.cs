using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    public class BookWrapper
    {
        private List<RentInfo> _rentInfo;
        private List<InventoryItem> _inventoryItem;
        public string Location { get; init; }

        public BookWrapper(string location)
        {
            location = location;
            _rentInfo = new List<RentInfo>();
            _inventoryItem = new List<InventoryItem>();
        }
    }
}
