using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerCompanySystem
{
    public abstract class Building
    {
        protected string name;
        private string city;
        private int stars;
        private double rentAmount;
        private bool isAvailable;

        public Building(string name, string city, int stars, double rentAmount)
        {
            Name = name;
            City = city;
            Stars = stars;
            RentAmount = rentAmount;
            IsAvailable = true;
        }

        public virtual string Name
        {
            get { return name; }
            protected set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Building name must not be null or empty!");
                }
                if (!value.EndsWith(this.GetType().Name))
                {
                    throw new ArgumentException($"Name of {this.GetType().Name.ToLower()} buildings should end on {this.GetType().Name}!");
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
                    throw new ArgumentException("City must not be null or empty!");
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
                    throw new ArgumentException("Stars cannot be less than 0 or above 5!");
                }
                stars = value;
            }
        }
        public double RentAmount
        {
            get { return rentAmount; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Rent amount cannot be less or equal to 0!");
                }
                rentAmount = value;
            }
        }
        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        public override string ToString()
        {
            string result = $"****Building: {this.Name} <{this.Stars}>{Environment.NewLine}" +
                $"****Location: {this.City}{Environment.NewLine}" +
                $"****RentAmount: {this.RentAmount}{Environment.NewLine}" +
                $"****Is Available: {this.IsAvailable}";

            return result;
        }
    }
}
