using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerCCompanySystemCode
{
    public class Company
    {
        private string name;
        private List<Building> buildings;
        private List<Broker> brokers;
        ////////////////////////////////////////////////////////////////////////////////////
        public Company(string name)
        {
            this.Name = name;
            this.buildings = new List<Building>();
            this.brokers = new List<Broker>();
        }

        ////////////////////////////////////////////////////////////////////////////////////
        
        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Company name must not be null or empty!");
                }
                name = value; 
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////
        
        public void AddBroker(Broker broker)
        {
            if (!this.brokers.Contains(broker))
            {
                this.brokers.Add(broker);
            }
        }
        public void AddBuilding(Building building)
        {
            if (!this.buildings.Contains(building))
            {
                this.buildings.Add(building);
            }
        }
        public Broker GetBrokerByName(string name)
        {
            Broker broker = this.brokers.Where(b => b.Name.Equals(name)).FirstOrDefault();
            return broker;
        }
        public Building GetBuildingByName(string name)
        {
            Building building = this.buildings.Where(b => b.Name.Equals(name)).FirstOrDefault();
            return building;
        }

        ////////////////////////////////////////////////////////////////////////////////////

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Company: {this.Name}");
            sb.AppendLine($"##Brokers: {this.brokers.Count}");
            foreach (Broker broker in this.brokers)
            {
                sb.AppendLine(broker.ToString());
            }
            sb.AppendLine($"##Buildings – {this.buildings.Count}");
            foreach (Building building in this.buildings)
            {
                sb.AppendLine(building.ToString());
            }
            return sb.ToString();
        }
    }
}
