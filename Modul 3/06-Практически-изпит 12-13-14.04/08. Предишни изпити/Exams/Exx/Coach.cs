using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exx
{
    public class Coach
    {
        private string name;
        private int experience;
        private List<Athlete> athletes;
        private double money;

        public Coach(string name, int experience)
        {
            this.Name = name;
            this.Experience = experience;
            athletes = new List<Athlete>();
            this.Money = 0;
        }
        public Coach(string name,int experience, double money): this(name,experience)
        {
            this.Money = money;
        }

        ///////////////////////////////////////////////////////////////////////////////

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public int Experience
        {
            get { return experience; }
            private set { experience = value; }
        }
        public double Money
        {
            get { return money; }
            private set 
            { 
                money = value; 
            }

        }

        ///////////////////////////////////////////////////////////////////////////////
        
        public override string ToString()
        {
            return $"Coach: {this.Name} has experience {this.Experience} and his current money balance is: {this.Money:f2}";
        }

        ///////////////////////////////////////////////////////////////////////////////

        public void AddNewClient(Athlete athlete)
        {
            this.athletes.Add(athlete);
        }
        public bool LooseClient(string name)
        {
            Athlete athlete = this.athletes.Where(n => n.Name.Equals(name)).FirstOrDefault();
            if(athlete == null)
            {
                return false;
            }
            else
            {
                this.athletes.Remove(athlete);
                return true;
            }
        }
        public int GetClientsCount()
        {
            return athletes.Count;
        }
        public List<Athlete> GetAllClientsTougherThan(int strength)
        {
            return this.athletes.Where(a => a.Strength > strength).ToList();
        }
        public void SpendMoneyOnSupplements(double money)
        {
            this.Money -= money;
        }
        public void TrainHard()
        {
            this.Experience += 5;
        }
        public void TrainClient(Athlete athlete)
        {
            athlete.IncreaseStrength(5);
            this.Experience++;
            this.Money += athlete.Strength * 0.75;
        }
        public int RemoveAllClientsLeakerThan(int strength)
        {
            int loosers = this.athletes.Where(a => a.Strength < strength).Count();
            this.athletes.RemoveAll(s => s.Strength < strength);
            return loosers;
        }
        public Athlete GetToughestClient()
        {
            return this.athletes.OrderByDescending(s => s.Strength).FirstOrDefault();
        }
    }
}
