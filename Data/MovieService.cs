using Microsoft.Data.Sqlite;
using MoviesDB.Models;

namespace MoviesDB.Data
{
    public class MovieService
    {
        private readonly string _connectionString = "Data Source=movies.db";

        public List<Movie> GetMovies()
        {
            var movies = new List<Movie>();

            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM movies";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                movies.Add(new Movie
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Overview = reader.GetString(2),
                    ReleaseDate = reader.GetString(3),
                    PosterPath = reader.GetString(4),
                    UserRating = reader.GetDouble(5),
                    Genres = reader.GetString(6),
                    Language = reader.GetString(7),
                    Adult = reader.GetBoolean(8)
                });
            }

            return movies;
        }
    }
}
