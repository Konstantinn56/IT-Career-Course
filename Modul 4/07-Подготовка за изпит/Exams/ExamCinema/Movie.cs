using System;
using System.Collections.Generic;
using System.Text;

namespace ExamCinema
{
    public class Movie
    {
        private string title;
        private double rating;

        public Movie(string title , double rating)
        {
            this.Title = title;
            this.Rating = rating;
        }

        public string Title
        {
            get
            {
                return title;
            }
            private set
            {
                this.title = value;
            }
        }
        public double Rating
        {
            get { return rating; }
            private set { this.rating = value; }
        }

        public override string ToString()
        {
            return $"Movie {this.Title} is with {this.Rating:f2} rating.";
        }
    }
}
