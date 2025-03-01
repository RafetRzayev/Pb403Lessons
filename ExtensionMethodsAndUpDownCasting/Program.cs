using System.Diagnostics;
using System.Reflection.Metadata;

namespace ExtensionMethodsAndUpDownCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(string item in Enum.GetNames(typeof(Weekday)))
            {
                Console.WriteLine(item);
            }
        }
    }

    enum Weekday
    {
        Monday,
        Tuesday,
        Wensday,
        Thursday,
        Friday = 8,
        Saturday,
        Sunday
    }

    public class MyIntegers
    {
        private int[] _integers;
        private int _size = 0;

        public const int SomeConstant = 6;
        public readonly int SomeReadOnlyConstant;

        public MyIntegers()
        {
            _integers = new int[4];
            SomeReadOnlyConstant = 56;
        }

        public int Count => _size;

        public int this[int index] 
        {
            get => _integers[index];
            set => _integers[index] = value;
        }

        public void Add(int integer)
        {
            if (_size >= _integers.Length)
            {
                int[] tmpIntegers = new int[_integers.Length * 2];
                
                Array.Copy(_integers, tmpIntegers, _integers.Length);
                _integers = tmpIntegers;
            }

            _integers[_size++] = integer;
        }

        public void RemoveAt(int index)
        {

            //12 34 46 46 0 0 0 0
            if (index < _size)
            {
                for (int i = index; i < _size - 1; i++)
                {
                    _integers[i] = _integers[i + 1];
                }
   
                _integers[_size - 1] = default;
                _size -= 1;
            }
            else
            {
                Console.WriteLine($"Index not found!");
            }
        }
        public int GetByIndex(int index)
        {
            return _integers[index];
        }

        public void SetByIndex(int index, int value)
        {
            _integers[index] = value;
        }

        public void Print()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine(_integers[i]);
            }
        }
    }

    public static class ExtensionMethods
    {
        public static void EvenOrOdd(this int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        public static string Capitalize(this string text)
        {
            if (string.IsNullOrEmpty(text)) return text;

            if (text[0] >= 'a' && text[0] <= 'z')
            {
                if (text.Length == 1)
                    return text[0].ToString().ToUpper();

                return text[0].ToString().ToUpper() + text.Substring(1);//hello
            }

            return text;
        }

        public static bool IsPrime(this int number)
        {
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
