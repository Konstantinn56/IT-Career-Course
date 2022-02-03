using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village
{
    public class Village
    {
        private string name;
        private string location;
        private int resource;
        private List<Peasant> peasants;

        public Village(string name, string location)
        {
            this.Name = name;
            this.Location = location;
            this.peasants = new List<Peasant>();
        }


        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length < 2 || value.Length > 40)
                {
                    throw new ArgumentException("Name should be between 2 and 40 characters!");
                }
                name = value;
            }
        }
        public string Location
        {
            get { return location; }
            private set
            {
                if (value.Length < 3 || value.Length > 45)
                {
                    throw new ArgumentException("Location should be between 3 and 45 characters!");
                }
                location = value;
            }
        }
        public int Resource
        {
            get { return resource; }
            private set { resource = value; }
        }

        public void AddPeasant(Peasant peasant)
        {
            this.peasants.Add(peasant);
        }
        public int PassDay()
        {
            int sumProductivity = this.peasants.Sum(p => p.Productivity);
            this.resource += sumProductivity;
            return sumProductivity;
        }
        public List<Peasant> KillPeasants(int count)
        {
            List<Peasant> result = new List<Peasant>();
            if (this.peasants.Count < count)
            {
                result = this.peasants;
                return result;
            }
            result = this.peasants.Take(count).ToList();
            this.peasants = this.peasants.Skip(count).ToList();
            return result;
        }
        public void Attack(int harm)
        {
            this.Resource -= harm;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Village - {this.Name} ({this.Location})");
            sb.AppendLine($"Resources: {this.Resource}");
            sb.Append($"Peasants: ({this.peasants.Count})");
            foreach (Peasant p in this.peasants)
            {
                sb.AppendLine();
                sb.Append(p.ToString());
            }
            return sb.ToString();
        }

    }
}

