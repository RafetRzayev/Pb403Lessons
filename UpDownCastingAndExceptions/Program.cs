
using System.Collections;

namespace UpDownCastingAndExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
        }
    }

    class Test : IHouse, IBoat
    {
        public void House()
        {
            throw new NotImplementedException();
        }

        void IBoat.Boat()
        {
        }
    }

    interface IHouse
    {
        void House();
    }

    interface IBoat
    {
        void Boat();
    }


    abstract class Animal
    {
       public abstract void MakeSound();
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("meow");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("bark");
        }
    }

    class Bird : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cik cik");
        }
    }

    class MyList<T>
    {
        private T[] _items = new T[4];
        private int _size = 0;

        public void Add(T item)
        {
            if (_size >= _items.Length)
            {
                T[] tmp = new T[_items.Length * 2];
                Array.Copy(_items, tmp, _items.Length);
                _items = tmp;
            }

            _items[_size++]= item;
        }

        public T this[int index] => _items[index];

        public int Count => _size;
    }

    class MyListWithoutGeneric
    {
        private object[] _items = new object[4];
        private int _size = 0;

        public void Add(object item)
        {
            if (_size >= _items.Length)
            {
                object[] tmp = new object[_items.Length * 2];
                Array.Copy(_items, tmp, _items.Length);
                _items = tmp;
            }

            _items[_size++] = item;
        }

        public object this[int index] => _items[index];

        public int Count => _size;
    }

}

