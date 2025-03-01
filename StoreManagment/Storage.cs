namespace StoreManagment
{
    public class Storage
    {
        private Product[] _products = new Product[3];
        private int _size = 2;

        public Storage()
        {
            //_products = [new Product("mi4", 23, Category.Watch), new Product("mac air", 23422, Category.Notebook)];
            _products[0] = new Product("mi4", 23, Category.Watch, 12);
            _products[1] = new Product("mac air", 23422, Category.Notebook, 5);
        }

        public void PrintProducts()
        {
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"{"Id",-4}{"Name",-20} {"Price",-10} {"Category", -12} {"Stock", -4}");

            for (int i = 0; i < _size; i++)
            {
                var item = _products[i];

                if (item == null) continue;

                Console.WriteLine(new string('-', 60));
                Console.WriteLine($"{item.Id, -4}{item.Name, -20 } {item.Price, -10} {item.Category, -12} {item.StockCount, -4}");
            }

            Console.WriteLine(new string('-', 60));
        }

        public void Add()
        {
            Console.Write("Enter name:");
            string name = Console.ReadLine();
            Console.Write("Enter price:");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Category:");
            int category = int.Parse(Console.ReadLine());
            Console.Write("Stock count:");
            int stockCount = int.Parse(Console.ReadLine());

            var product = new Product(name, price, (Category)category, stockCount);

            if (_size >= _products.Length)
            {
                Product[] tmpProducts = new Product[_products.Length * 2];
                Array.Copy(_products, tmpProducts, _products.Length);
                _products = tmpProducts;
            }

            _products[_size++] = product;

            Console.WriteLine("Successfully added");
        }

        public void Update()
        {
            Console.WriteLine("Enter the product id for updating...");
            PrintProducts();
            Console.Write("Id:");
         
            int id;

            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Id not found");

                return;
            }

            bool found = false;

            for (int i = 0; i < _size; i++)
            {
                if (_products[i].Id == id)
                {
                    Console.Write($"Enter name(old name:{_products[i].Name}):");
                    string name = Console.ReadLine();
                    Console.Write($"Enter price(old price:{_products[i].Price}):");
                    decimal price = decimal.Parse(Console.ReadLine());
                    Console.Write("Category:");
                    int category = int.Parse(Console.ReadLine());
                    _products[i].Name = name;
                    _products[i].Price = price;
                    _products[i].Category = (Category)category;
                    found = true;

                    Console.WriteLine("Successfully updated");
                    return;
                }

            }

            if (!found)
                Console.WriteLine("Not found");
        }

        public void BuyProduct(User user)
        {
            Console.WriteLine("Choose product id from table");
            PrintProducts();

            Console.Write("Enter product and count with space:[12 4, 34 6]");
            string[] inputs = Console.ReadLine().Split(",");

            var basket = new Basket();

            for (int i = 0; i < inputs.Length; i++)
            {
                var productInputs = inputs[i].Split();
                int productId = int.Parse(productInputs[0]);
                int count = int.Parse(productInputs[1]);

                var product = GetProductById(productId);

                if (product == null)
                {
                    Console.WriteLine($"Product not found : {productId}");

                    continue;
                }

                if (product.StockCount < count)
                {
                    Console.WriteLine("Stockda yoxdur");

                    continue;
                }

                basket.Add(product, count);
                product.StockCount -= count;
            }

            basket.Print();

            if (basket.GetTotal() > user.Balance)
            {
                basket.Recharge();

                Console.WriteLine("Pulun catmir");
            }
            else
            {
                Console.WriteLine("Ugurlar, yeniden gozleyirik");

            }
        }

        private Product GetProductById(int id)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_products[i].Id == id)
                    return _products[i];
            }

            return default;
        }
    }
}
