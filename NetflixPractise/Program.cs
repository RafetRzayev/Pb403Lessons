using NetflixPractise.Models;

namespace NetflixPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage();

            while (true)
            {
                Console.WriteLine("Enter command:");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "print genre":
                        storage.PrintGenres();
                        break;
                    case "add genre":
                        storage.AddGenre();
                        break;
                    case "remove genre":
                        storage.RemoveGenre();
                        break;
                    case "print movie":
                        storage.PrintMovie();
                        break;
                    case "add movie":
                        storage.AddMovie();
                        break;
                    case "remove movie":
                        storage.RemoveMovie();
                        break;
                    case "Watch movie":
                        storage.Watch();
                        break;
                    case "Search movie":
                        storage.Search();
                        break;
                    case "Most view":
                        storage.MostViewedMovie();
                        break;
                    default:
                        Console.WriteLine("Command not right");
                        break;
                }
            }
        }
    }
}
