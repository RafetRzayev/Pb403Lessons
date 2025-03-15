namespace Delegates
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("I am test");
        }
        
        static string Capitalize(string word)
        {
            if (string.IsNullOrEmpty(word))
                return word;

            if (char.IsLetter(word[0]))
            {
                if (word.Length == 1)
                    return word[0].ToString().ToUpper();

                return word[0].ToString().ToUpper() + word.Substring(1);
            }

            return word;
        }

        static void IsEven(int number)
        {
            Console.WriteLine(number % 2 == 0);
        }
    }

    public static class MyExtensions
    {
        public static List<T> MyWhere<T>(this List<T> source, Func<T, bool> predicate)
        {
            var list = new List<T>();

            foreach (var item in source)
            {
                if (predicate.Invoke(item))
                    list.Add(item);
            }

            return list;
        }

        public static T MyFind<T>(this List<T> source, Predicate<T> predicate)
        {
            foreach (var item in source)
            {
                if (predicate.Invoke(item))
                {
                    return item;
                }
            }

            return default;
        }

        public static int MyIndexOf<T>(this List<T> source, Predicate<T> predicate)
        {
            for (int i = 0; i < source.Count; i++)
            {
                if (predicate.Invoke(source[i]))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
