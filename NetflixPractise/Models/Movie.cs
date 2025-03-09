namespace NetflixPractise.Models
{
    class Movie : Entity
    {
        private static int _autoIncrementId = 1;
        private int _numberOfViews = 0;

        public Movie(string name, Genre genre)
        {
            Name = name;
            Id = _autoIncrementId++;
            Genre = genre;
        }

        public string Name { get; set; }
        public Genre Genre { get; set; }

        public int NumberOfViews => _numberOfViews;

        public void IncrementWatchCount()
        {
            _numberOfViews++;
        }
    }
}
