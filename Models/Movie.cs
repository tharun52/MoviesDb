namespace MoviesDB.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string ReleaseDate { get; set; }
        public string PosterPath { get; set; }
        public double UserRating { get; set; }
        public string Genres { get; set; }
        public string Language { get; set; }
        public bool Adult { get; set; }
    }
}
