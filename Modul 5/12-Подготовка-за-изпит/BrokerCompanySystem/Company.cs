using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerCompanySystem
{
    class Company
    {
        private string name;
        private List<Building> buildings;
        private List<Broker> brokers;

        public Company(string name)
        {
            this.Name = name;
            this.buildings = new List<Building>();
            this.brokers = new List<Broker>();
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Company name must not be null or empty!");
                }
                name = value;
            }
        }

        public void AddBroker(Broker broker)
        {
            Broker searched = this.GetBrokerByName(broker.Name) ;//this.brokers.Where(b => b.Name.Equals(broker.Name)).FirstOrDefault();
            if(searched == null)
            {
                this.brokers.Add(broker);
            }
        }

        public void AddBuilding(Building building)
        {
            Building searched = this.GetBuildingByName(building.Name);//this.buildings.Where(b => b.Name.Equals(building.Name)).FirstOrDefault();
            if(searched == null)
            {
                this.buildings.Add(building);
            }
        }

        public Broker GetBrokerByName(string name)
        {
            return this.brokers.Where(b => b.Name.Equals(name)).FirstOrDefault();
        }

        public Building GetBuildingByName(string name)
        {
            return this.buildings.Where(b => b.Name.Equals(name)).FirstOrDefault();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Company: {this.Name}");
            sb.AppendLine($"##Brokers: {this.brokers.Count}");
            foreach (var broker in this.brokers)
            {
                sb.AppendLine(broker.ToString());
            }
            sb.AppendLine($"##Buildings – {this.buildings.Count}");
            foreach (var building in this.buildings)
            {
                sb.AppendLine(building.ToString());
            }
            return sb.ToString();
        }
    }
}
