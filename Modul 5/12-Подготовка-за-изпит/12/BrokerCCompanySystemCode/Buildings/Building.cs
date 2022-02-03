using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerCCompanySystemCode
{
    public abstract class Building
    {
        private string name;
        private string city;
        private int stars;
        private double rentAmount;
        public bool isAvailable;

        ////////////////////////////////////////////////////////////////////////////////////
        public Building(string name, string city, int stars, double rentAmount)
        {
            this.Name = name;
            this.City = city;
            this.Stars = stars;
            this.RentAmount = rentAmount;
        }

        ////////////////////////////////////////////////////////////////////////////////////

        public string Name
        {
            get { return name; }
            private set 
            { 
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Building name must not be null or empty!");
                }
                if (value.EndsWith(GetTypeOfBuilding()))
                {
                    throw new ArgumentException($"Name of {GetTypeOfBuilding().ToLower()} buildings should end on {GetTypeOfBuilding()}!");
                }
                name = value; 
            }
        }
        public string City
        {
            get { return city; }
            private set 
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
            private set 
            { 
                if(value < 0 || value > 5)
                {
                    throw new ArgumentException("Stars cannot be less than 0 or above 5!");
                }
                stars = value; 
            }
        }
        public double RentAmount
        {
            get { return rentAmount; }
            private set 
            { 
                if(value <= 0)
                {
                    throw new ArgumentException("Rent amount cannot be less or equal to 0!");
                }
                rentAmount = value; 
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////
        public string GetTypeOfBuilding()
        {
            return this.GetType().Name;
        }

        ////////////////////////////////////////////////////////////////////////////////////
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****Building: {this.Name} <{this.Stars}>");
            sb.AppendLine($"****Location: {this.City}");
            sb.AppendLine($"****RentAmount: {this.RentAmount}");
            sb.AppendLine($"****Is Available: {this.isAvailable}");
            return sb.ToString();
        }
        
    }
}
