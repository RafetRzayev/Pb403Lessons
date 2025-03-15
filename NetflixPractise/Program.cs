using NetflixPractise.Models;
using System.Net.Security;

namespace NetflixPractise
{
    internal class Program
    {
        public delegate void Command();

        static void Main(string[] args)
        {
            Storage storage = new Storage();
            var dict = new Dictionary<string, Command>
            {
                { "print genre", storage.PrintGenres },
                { "add genre", storage.AddGenre }
            };

            while (true)
            {
                Console.WriteLine("Enter command:");
                string command = Console.ReadLine();

                if (dict.TryGetValue(command, out Command action))
                {
                    action.Invoke();
                }
                else
                {
                    Console.WriteLine("Command not right");
                }

                //switch (command)
                //{
                //    case "print genre":
                //        storage.PrintGenres();
                //        break;
                //    case "add genre":
                //        storage.AddGenre();
                //        break;
                //    case "remove genre":
                //        storage.RemoveGenre();
                //        break;
                //    case "print movie":
                //        storage.PrintMovie();
                //        break;
                //    case "add movie":
                //        storage.AddMovie();
                //        break;
                //    case "remove movie":
                //        storage.RemoveMovie();
                //        break;
                //    case "Watch movie":
                //        storage.Watch();
                //        break;
                //    case "Search movie":
                //        storage.Search();
                //        break;
                //    case "Most view":
                //        storage.MostViewedMovie();
                //        break;
                //    default:
                //        Console.WriteLine("Command not right");
                //        break;
                //}
            }
        }
    }
}
