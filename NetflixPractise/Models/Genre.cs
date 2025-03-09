namespace NetflixPractise.Models
{
    class Genre : Entity
    {
        private static int _autoIncrementId = 1;

        public Genre(string name)
        {
            Name = name;
            Id = _autoIncrementId++;
        }

        public string Name { get; set; }
    }
}
