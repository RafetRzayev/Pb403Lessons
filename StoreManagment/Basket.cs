using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagment
{
    public class Basket
    {
        private BasketItemModel[] _basketItems;
        private int _size = 0;

        public Basket()
        {
            _basketItems = new BasketItemModel[4];
        }

        public void Add(Product product, int count)
        {
            if (_size >= _basketItems.Length)
            {
                BasketItemModel[] tmpProducts = new BasketItemModel[_basketItems.Length * 2];
                Array.Copy(_basketItems, tmpProducts, _basketItems.Length);
                _basketItems = tmpProducts;
            }

            _basketItems[_size++] = new BasketItemModel(product, count);

            Console.WriteLine("Successfully added");
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"{"Name",-20} {"Price",-6} {"Count",-6} {"Sum",-6}");
            decimal totalSum = 0;
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine($"{_basketItems[i].Product.Name,-20}" +
                    $" {_basketItems[i].Product.Price,-6}" +
                    $" {_basketItems[i].Count,-6}" +
                    $" {_basketItems[i].Total,-6}");

                totalSum += _basketItems[i].Total;
            }

            Console.WriteLine($"Total sum: {totalSum}");
        }

        public decimal GetTotal()
        {
            decimal total = 0;

            for (int i = 0; i < _size; i++)
            {
                total += _basketItems[i].Total;
            }

            return total;
        }
    }

    public class BasketItemModel
    {
        public BasketItemModel(Product product, int count)
        {
            Product = product;
            Count = count;
        }

        public Product Product { get; }
        public int Count { get; }
        public decimal Total
        {
            get
            {
                return Product.Price * Count;
            }
        }
    }
}
