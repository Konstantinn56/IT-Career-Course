using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerCompanySystem
{
    class Broker
    {
        private string name;
        private int age;
        private string city;
        private double bonus;
        private List<Building> buildings;

        public Broker(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
            this.buildings = new List<Building>();
        }

        
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
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
                if (value < 16 || value > 70)
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("City must not be null or empty!");
                }
                city = value;
            }
        }
        public double Bonus
        {
            get { return bonus; }
            //set { bonus = value; }
        }

        public double ReceiveBonus(Building building)
        {
            //{Building rent amount} * 2 * {building stars} / 100
            double currentBonus = building.RentAmount * 2 * building.Stars / 100;
            this.bonus += currentBonus;
            this.buildings.Add(building);

            return currentBonus;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****Broker: {Name} <{Age}>");
            sb.AppendLine($"****Location: {City}");
            sb.Append($"****Bonus: {Bonus}");
            foreach (var building in this.buildings)
            {
                sb.AppendLine();
                sb.Append($"****** {building.Name}");
            }
            return sb.ToString();
        }
    }
}
