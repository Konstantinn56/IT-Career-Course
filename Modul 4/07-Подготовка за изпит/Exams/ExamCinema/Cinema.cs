using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamCinema
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

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public List<Movie> Movies
        {
            get { return movies; }
            set { movies = value; }
        }

        ////////////////////////////////////////////////////////////////
        
        public void AddMovie(string title, double rating)
        {
            Movie movie = new Movie(title, rating);
            this.Movies.Add(movie);
        }
        public double AverageRating()
        {
            double average = this.Movies.Average(m => m.Rating);
            return average;
        }
        public List<string> RemoveMoviesByRating(double rating)
        {
            List<string> removedMovies = this.Movies
                .Where(m => m.Rating == rating)
                .Select(m => m.Title)
                .ToList();
            
            for (int i = 0; i < this.Movies.Count; i++)
            {
                if(this.Movies[i].Rating == rating)
                {
                    this.Movies.RemoveAt(i);
                }
            }
            return removedMovies;
        }
        public List<Movie> SortByTitle()
        {
            List<Movie> sortedMovies = this.Movies.OrderBy(m => m.Title).ToList();
            return sortedMovies;
        }
        public List<Movie> SortByRating()
        {
            List<Movie> sortedMovies = this.Movies.OrderByDescending(m => m.Rating).ToList();
            return sortedMovies;
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
            bool result = this.Movies
                .Where(m => m.Title.Equals(title))
                .SingleOrDefault() != null ? true : false;
            return result;
        }
        public List<string> GetMoviesByRating(double rating)
        {
            return this.Movies
                .Where(m => m.Rating > rating)
                .Select(m => m.Title)
                .ToList();
        }
    }
}
