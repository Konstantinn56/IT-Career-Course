using System;
using System.Collections.Generic;
using System.Text;

namespace Exx
{
    public class Athlete
    {
        private string name;
        private int age;
        private int strength;

        
        public Athlete(string name, int age, int strength)
        {
            this.Name = name;
            this.Age = age;
            this.Strength = strength;
        }

        ///////////////////////////////////////////////////////////////////////////////
       
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }
        public int Strength
        {
            get { return strength; }
            private set { strength = value; }
        }

        ///////////////////////////////////////////////////////////////////////////////

        public override string ToString()
        {
            return $"Athlete: name - {this.Name}, age - {this.Age}, strength {this.Strength}";
        }

        ///////////////////////////////////////////////////////////////////////////////
        
        public void IncreaseStrength(int amount)
        {
            this.Strength += amount;
        }
    }
}
