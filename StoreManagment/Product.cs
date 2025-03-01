namespace StoreManagment
{
    public class Product
    {
        private static int _autoIncrementId = 34;

        public Product(string name, decimal price, Category category)
        {
            Name = name;
            Price = price;
            Category = category;
            Id = _autoIncrementId++;
        }

        public int Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
    }
}
