using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    public abstract class Building
    {
        protected string name;
        private string city;
        private int stars;
        private double rentAmount;
        private bool isAvailable;

        protected Building(string name, string city, int stars, double rentAmount, bool isAvailable)
        {
            Name = name;
            City = city;
            Stars = stars;
            RentAmount = rentAmount;
            this.isAvailable = isAvailable;
        }

        public virtual string Name
        {
            get { return name; }
            protected set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value" , "Building name must NOT be null or empty!");
                }
                if (!value.EndsWith($"{this.GetType().Name}"))
                {
                    throw new ArgumentException($"Name of {this.GetType().Name.ToLower()} must end on {this.GetType().Name}");
                }
                name = value; 
            }
        }
        public string City
        {
            get { return city; }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "City must NOT be null or empty!");
                }
                city = value; 
            }
        }
        public int Stars
        {
            get { return stars; }
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentOutOfRangeException("value", "Stars cannot be less than 0 or above 5!");
                }
                stars = value; 
            }
        }
        public double RentAmount
        {
            get { return rentAmount; }
            set 
            { 
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Rent amount must be a positive number!");
                }
                rentAmount = value; 
            }
        }

        public override string ToString()
        {
            string result = $"{this.Name} " + $"{this.City} " + $"{this.RentAmount} " + $"{this.isAvailable} ";
            return result;
        }
    }
}
