using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaExam
{
    public class Movie
    {
        private string title;
        private double rating;

        public Movie(string title, double rating)
        {
            Title = title;
            Rating = rating;
        }

        public string Title
        {
            get => this.title;
            private set => this.title = value;
        }
        public double Rating 
        { 
            get => this.rating; 
            private set => this.rating = value;
        }

        public override string ToString()
        {
            return $"Movie {this.Title} is with {this.Rating:f1} rating.";
        }
    }
}
