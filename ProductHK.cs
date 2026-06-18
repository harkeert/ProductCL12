namespace ProductCL12
{
    public class ProductHK
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int StockCount { get; set; }

        public ProductHK(
            int itemID,
            string itemName,
            double itemPrice,
            int stockCount)
        {
            ItemID = itemID;
            ItemName = itemName;
            ItemPrice = itemPrice;
            StockCount = stockCount;
        }

        public void IncreaseStock(int amount)
        {
            StockCount += amount;
        }

        public void DecreaseStock(int amount)
        {
            StockCount -= amount;
        }

        public int CheckStock()
        {
            return StockCount;
        }
    }
}