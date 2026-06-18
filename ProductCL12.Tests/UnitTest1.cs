namespace ProductCL12.Tests
{
    public class Tests
    {
        private ProductHK product;

        [SetUp]
        public void Setup()
        {
            product = new ProductHK(101, "Laptop", 999.99, 10);
        }

        [Test]
        public void Constructor_Sets_ItemID()
        {
            Assert.That(product.ItemID, Is.EqualTo(101));
        }

        [Test]
        public void Constructor_Sets_ItemName()
        {
            Assert.That(product.ItemName, Is.EqualTo("Laptop"));
        }

        [Test]
        public void Constructor_Sets_ItemPrice()
        {
            Assert.That(product.ItemPrice, Is.EqualTo(999.99));
        }

        [Test]
        public void Constructor_Sets_StockCount()
        {
            Assert.That(product.StockCount, Is.EqualTo(10));
        }

        [Test]
        public void IncreaseStock_ByFive()
        {
            product.IncreaseStock(5);
            Assert.That(product.StockCount, Is.EqualTo(15));
        }

        [Test]
        public void IncreaseStock_ByOne()
        {
            product.IncreaseStock(1);
            Assert.That(product.StockCount, Is.EqualTo(11));
        }

        [Test]
        public void IncreaseStock_ByZero()
        {
            product.IncreaseStock(0);
            Assert.That(product.StockCount, Is.EqualTo(10));
        }

        [Test]
        public void IncreaseStock_ByLargeAmount()
        {
            product.IncreaseStock(100);
            Assert.That(product.StockCount, Is.EqualTo(110));
        }

        [Test]
        public void DecreaseStock_ByFive()
        {
            product.DecreaseStock(5);
            Assert.That(product.StockCount, Is.EqualTo(5));
        }

        [Test]
        public void DecreaseStock_ByOne()
        {
            product.DecreaseStock(1);
            Assert.That(product.StockCount, Is.EqualTo(9));
        }

        [Test]
        public void DecreaseStock_ToZero()
        {
            product.DecreaseStock(10);
            Assert.That(product.StockCount, Is.EqualTo(0));
        }

        [Test]
        public void CheckStock_ReturnsInitialStock()
        {
            Assert.That(product.CheckStock(), Is.EqualTo(10));
        }

        [Test]
        public void CheckStock_AfterIncrease()
        {
            product.IncreaseStock(5);
            Assert.That(product.CheckStock(), Is.EqualTo(15));
        }

        [Test]
        public void CheckStock_AfterDecrease()
        {
            product.DecreaseStock(3);
            Assert.That(product.CheckStock(), Is.EqualTo(7));
        }

        [Test]
        public void ChangeItemName()
        {
            product.ItemName = "Phone";
            Assert.That(product.ItemName, Is.EqualTo("Phone"));
        }

        [Test]
        public void ChangeItemPrice()
        {
            product.ItemPrice = 499.99;
            Assert.That(product.ItemPrice, Is.EqualTo(499.99));
        }

        [Test]
        public void ChangeItemID()
        {
            product.ItemID = 202;
            Assert.That(product.ItemID, Is.EqualTo(202));
        }

        [Test]
        public void ChangeStockCountDirectly()
        {
            product.StockCount = 50;
            Assert.That(product.StockCount, Is.EqualTo(50));
        }

        [Test]
        public void MultipleIncreaseOperations()
        {
            product.IncreaseStock(5);
            product.IncreaseStock(10);
            Assert.That(product.StockCount, Is.EqualTo(25));
        }

        [Test]
        public void MultipleDecreaseOperations()
        {
            product.DecreaseStock(2);
            product.DecreaseStock(3);
            Assert.That(product.StockCount, Is.EqualTo(5));
        }
    }
}