using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    public class Broker
    {
        private string name;
        private int age;
        private string city;
        private double bonus;
        private List<Building> buildings;

        ///////////////////////////////////////////////////////////////////////////////////////////
        public Broker(string name, int age, string city)
        {
            this.Name = name;
            this.Age = age;
            this.City = city;
            this.buildings = new List<Building>();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Broker name must not be null or empty!");
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
                    throw new ArgumentOutOfRangeException("The age must be between [16..70]");
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
                    throw new ArgumentNullException("City must not be null or empty!");
                }
                city = value;
            }
        }
        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        public void AddBuilding(Building building)
        {
            this.buildings.Add(building);
        }
        public double ReceiveBonus(Building building)
        {
            double currentBonus = building.RentAmount * 2 * building.Stars / 100;
            this.Bonus += currentBonus;
            this.buildings.Add(building);
            return currentBonus;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****Broker:{this.Name} <{this.Age}>");
            sb.AppendLine($"****Location: {this.City}");
            sb.AppendLine($"****Bonus: {this.Bonus}");
            foreach (Building b in buildings)
            {
                sb.AppendLine($"**** {b.Name}");
            }
            return sb.ToString().Trim();
        }

    }
}
