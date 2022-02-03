using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaExam
{
    public class Cinema
    {
        private string name;
        private List<Movie> movies;

        public Cinema(string name)
        {
            this.Name = name;
            this.Movies = new List<Movie>();
        }
        public List<Movie> Movies
        {
            get { return movies; }
            private set { movies = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public void AddMovie(string title, double rating)
        {
            Movie movie = new Movie(title, rating);
            this.Movies.Add(movie);
        }



        public double AverageRating()
        {
            return this.Movies.Average(m => m.Rating);
        }



        public List<string> RemoveMoviesByRating(double rating)
        {
            List<string> removedMovies = this.Movies
                .Where(m => m.Rating < rating)
                .Select(m => m.Title).ToList();

            for (int i = 0; i < this.Movies.Count; i++)
            {
                if(this.Movies[i].Rating < rating)
                {
                    this.Movies.RemoveAt(i);
                }
            }

            return removedMovies;
        }


        public List<Movie> SortByTitle()
        {
            this.Movies = this.Movies.OrderBy(m => m.Title).ToList();
            return this.Movies;
        }



        public List<Movie> SortByRating()
        {
            return this.Movies = this.Movies.OrderByDescending(m => m.Rating).ToList();
        }



        public string[] ProvideInformationAboutAllMovies()
        {
            string[] allMovies = new string[this.Movies.Count];

            for (int i = 0; i < this.Movies.Count; i++)
            {
                allMovies[i] = this.Movies[i].ToString();
            }

            return allMovies;
        }



        public bool CheckMovieIsInCinema(string title)
        {
            return this.Movies
                .Where(m => m.Title.Equals(title))
                .SingleOrDefault() != null ? true : false;
        }

        public List<string> GetMoviesByRating(double rating)
        {
            return this.Movies
                .Where(m => m.Rating > rating)
                .Select(m => m.Title).ToList();
        }
    }
}
