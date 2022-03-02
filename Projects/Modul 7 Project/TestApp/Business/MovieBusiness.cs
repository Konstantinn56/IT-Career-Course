using Data;
using Data.Model;

namespace Business
{
    /// <summary>
    /// Business Logic of the App
    /// </summary>
    public class MovieBusiness
    {
        private MovieContext movieContext = null;

        /// <summary>
        /// Get all movies from the database
        /// </summary>
        /// <returns>List of Movies</returns>
        public List<Movie> GetAll()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Movies.ToList();
            }
        }

        /// <summary>
        /// Get movie by index from the database
        /// </summary>
        /// <param name="id">Movie Id</param>
        /// <returns>Movie</returns>
        /// <exception cref="InvalidOperationException">Index not Found</exception>
        public Movie Get(int id)
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Movies.Find(id);
            }
        }

        /// <summary>
        /// Add a movie to the database
        /// </summary>
        public void Add(Movie movie)
        {
            using (movieContext = new MovieContext())
            {
                movieContext.Movies.Add(movie);
                movieContext.SaveChanges();
            }
        }

        /// <summary>
        /// Update a single movie in the database by Id.
        /// </summary>
        public void Update(Movie movie)
        {
            using (movieContext = new MovieContext())
            {
                var item = movieContext.Movies.Find(movie.Id);
                if (item != null)
                {
                    movieContext.Entry(item).CurrentValues.SetValues(movie);
                    movieContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Deleate a movie from the database by Id
        /// </summary>
        public void Delete(int id)
        {
            using (movieContext = new MovieContext())
            {
                var movie = movieContext.Movies.Find(id);
                if (movie != null)
                {
                    movieContext.Movies.Remove(movie);
                    movieContext.SaveChanges();
                }
            }
        }
    }
}