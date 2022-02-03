using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._8._1
{
    class AllPeople
    {
        private List<Citizen> citizens = new List<Citizen>();
        private List<Robot> robots = new List<Robot>();
        public List<Citizen> Citizens
        {
            get { return citizens; }
            set { citizens = value; }
        }
        public List<Robot> Robots
        {
            get { return robots; }
            set { robots = value; }
        }


        public void AddRobot(string model, string id)
        {
            this.Robots.Add(new Robot(model, id));
        }
        public void AddCitizens(string name, int age, string id)
        {
            this.Citizens.Add(new Citizen(name, age, id));
        }
        public string GetLastThreeNums(string id)
        {
            
            if (id.Length == 3)
            {
                return id;
            }
            return id.Substring(id.Length - 3);
        }
        public List<string> Arrest(string id)
        {
            List<string> removedIds = new List<string>();
            foreach (var c in this.Citizens)
            {
                string currentId = GetLastThreeNums(c.Id);
                if(currentId == id)
                {
                    removedIds.Add(c.Id);
                }
                
            }
            foreach (var r in this.Robots)
            {
                string currentId = GetLastThreeNums(r.Id);
                if (currentId == id)
                {
                    removedIds.Add(r.Id);
                }
            }
            return removedIds;
        }
    }
}
