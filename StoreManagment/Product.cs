namespace StoreManagment
{
    public class Product
    {
        private static int _autoIncrementId = 34;

        public Product(string name, decimal price, Category category, int stockCount)
        {
            Name = name;
            Price = price;
            Category = category;
            StockCount = stockCount;
            Id = _autoIncrementId++;
        }

        public int Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public int StockCount { get; set; }
    }
}
