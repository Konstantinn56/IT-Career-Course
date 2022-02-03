using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerCCompanySystemCode
{
    public class Broker
    {
        private string name;
        private int age;
        private string city;
        protected double bonus;
        private List<Building> buildings;
        ////////////////////////////////////////////////////////////////////////////////////
        public Broker(string name, int age, string city)
        {
            this.Name = name;
            this.Age = age;
            this.City = city;
            this.buildings = new List<Building>();
        }

        ////////////////////////////////////////////////////////////////////////////////////
        
        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Broker name must not be null or empty!");
                }
                name = value; 
            }
        }
        public int Age
        {
            get { return age; }
            set 
            { 
                if(value < 16 || value > 70)
                {
                    throw new ArgumentException("Broker's age cannot be less than 16 or above 70!");
                }
                age = value; 
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
        ////////////////////////////////////////////////////////////////////////////////////

        public double ReceiveBonus(Building building)
        {
            double newBonus = building.RentAmount * 2 * building.Stars / 100;
            this.bonus += newBonus;
            this.buildings.Add(building);
            return newBonus;
            
        }

        ////////////////////////////////////////////////////////////////////////////////////
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****Broker: {this.Name} <{this.Age}>");
            sb.AppendLine($"****Location: {this.City}");
            sb.Append($"****Bonus: {this.bonus}");
            foreach (Building building in buildings)
            {
                sb.AppendLine();
                sb.Append($"****** {building.Name}");
            }
            return sb.ToString();
        }
    }
}
