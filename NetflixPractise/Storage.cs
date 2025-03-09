using NetflixPractise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixPractise
{
    class Storage
    {
        private List<Genre> _genres = new List<Genre>();
        private List<Movie> _movies = new List<Movie>();
        private List<Movie> _watchList = new List<Movie>();

        public Storage()
        {
            _genres.Add(new Genre("Comedy"));
            _genres.Add(new Genre("Dram"));

            _movies.Add(new Movie("Seven", _genres[1]));
            _movies.Add(new Movie("Friends", _genres[0]));
        }

        public void AddGenre()
        {
            Console.WriteLine("Process of adding genre");
            Console.Write("Name:");
            string name = Console.ReadLine();

            var addedGenre = new Genre(name);
            _genres.Add(addedGenre);
        }

        public void RemoveGenre()
        {
            PrintGenres();

            Console.WriteLine("Process of removing genre");
            Console.Write("Enter id:");
            int id = int.Parse(Console.ReadLine());

            foreach(var genre in _genres)
            {
                if (genre.Id == id)
                {
                    _genres.Remove(genre);
                    return;
                }
            }

            Console.WriteLine("Not found");
        }

        public void PrintGenres()
        {
            Console.WriteLine(new string('-', 40));

            Console.WriteLine($"{"ID",-4} {"Name",-30}");

            foreach (var genre in _genres)
            {
                if (genre == null) continue;

                Console.WriteLine($"{genre.Id,-4} {genre.Name,-30}");

                Console.WriteLine(new string('-', 40));
            }
        }

        public void AddMovie()
        {
            Console.WriteLine("Process of adding movie");
            Console.Write("Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Choose genre id:");
            PrintGenres();
            Console.WriteLine("Enter genre id:");
            int genreId = int.Parse(Console.ReadLine());
            var existGenre = GetGenreById(genreId);

            if (existGenre == null)
            {
                Console.WriteLine("Genre not found");

                return;
            }

            var addedMovie = new Movie(name, existGenre);
            _movies.Add(addedMovie);
        }

        public void RemoveMovie()
        {
            PrintMovie();

            Console.WriteLine("Process of removing movie");
            Console.Write("Enter id:");
            int id = int.Parse(Console.ReadLine());

            foreach (var movie in _movies)
            {
                if (movie.Id == id)
                {
                    _movies.Remove(movie);
                    return;
                }
            }

            Console.WriteLine("Not found");
        }

        public void PrintMovie()
        {
            Console.WriteLine(new string('-', 70));

            Console.WriteLine($"{"ID",-4} {"Name",-30} {"Genre",-20} {"View count"}");

            foreach (var movie in _movies)
            {
                if (movie == null) continue;

                Console.WriteLine($"{movie.Id,-4} {movie.Name,-30} {movie.Genre.Name, -20} {movie.NumberOfViews}");

                Console.WriteLine(new string('-', 70));
            }
        }

        public void Watch()
        {
            Console.WriteLine("Process of watching..");

            PrintMovie();

            Console.WriteLine("Enter movie id for watching:");
            int id = int.Parse(Console.ReadLine());

            var existMovie = GetMovieById(id);

            if (existMovie == null)
            {
                Console.WriteLine("Not found");

                return;
            }

            existMovie.IncrementWatchCount();
        }

        public Genre GetGenreById(int id)
        {
            foreach (var item in _genres)
            {
                if (item.Id == id)
                    return item;
            }

            return default;
        }

        public Movie GetMovieById(int id)
        {
            foreach (var item in _movies)
            {
                if (item.Id == id)
                    return item;
            }

            return default;
        }

        public void Search()
        {
            Console.Write("Search:");
            var search = Console.ReadLine();

            foreach (var movie in _movies)
            {
                if (movie.Name.Contains(search, StringComparison.InvariantCultureIgnoreCase) || movie.Genre.Name.Contains(search, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"{movie.Id,-4} {movie.Name,-30} {movie.Genre.Name,-20} {movie.NumberOfViews}");
                }
            }
        }

        public void MostViewedMovie()
        {
            int max = _movies[0].NumberOfViews;
         
            foreach (var item in _movies)
            {
                if (item.NumberOfViews >= max)
                {
                    max = item.NumberOfViews;
                }
            }

            foreach (var movie in _movies)
            {
                if (movie.NumberOfViews == max)
                {
                    Console.WriteLine($"{movie.Id,-4} {movie.Name,-30} {movie.Genre.Name,-20} {movie.NumberOfViews}");
                }
            }
        }

        public void AddWatchList()
        {
            PrintMovie();

            int id = int.Parse(Console.ReadLine());
            var movie = GetMovieById(id);

            if (movie == null)
            {
                return;
            }

            _watchList.Add(movie);
        }
    }
}
