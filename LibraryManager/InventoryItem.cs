namespace examples
{
    internal class InventoryItem
    {
        private Book _books;
        public string InventoryId { get; init; }
       
        private ItemStatus _itemStatus;

        public InventoryItem(string inventoryid)
        {
            InventoryId = inventoryid;
            _itemStatus = ItemStatus.Avaiable;

        }
    }
}