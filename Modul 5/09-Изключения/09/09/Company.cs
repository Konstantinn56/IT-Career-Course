using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    public class Company
    {
        private string name;
        private List<Building> buildings;
        private List<Broker> brokers;

        //////////////////////////////////////////////////////////////////////////////
        public Company(string nm)
        {
            this.Name = nm;
            this.buildings = new List<Building>();
            this.brokers = new List<Broker>();
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //////////////////////////////////////////////////////////////////////////////

        public void AddBroker(Broker broker)
        {
            if (!this.brokers.Contains(broker))
            {
                this.brokers.Add(broker);
            }
        }
        public void AddBuilding(Building bd)
        {
            if(GetBuildingByName(bd.Name) == null)
            {
                this.buildings.Add(bd);
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

        //////////////////////////////////////////////////////////////////////////////

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Company: {this.Name}");
            sb.AppendLine($"##Brokers: {this.brokers.Count}");
            foreach (Broker broker in this.brokers)
            {
                sb.AppendLine(broker.ToString());
            }
            sb.AppendLine($"##Building: {this.buildings.Count}");
            foreach (Building building in this.buildings)
            {
                sb.AppendLine(building.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
