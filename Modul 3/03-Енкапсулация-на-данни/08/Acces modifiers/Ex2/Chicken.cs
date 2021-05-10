using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    public class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;

        private string name;
        private int age;

        public Chicken(string name, int age)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Name cannot be empty.");
            }
            this.name = name;
            if (MinAge > age || MaxAge < age)
            {
                throw new Exception("Age should be between 0 and 15.");
            }
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
        }
        public int Age
        {
            get { return this.age;}
        }



        public double GetProductPerDay()
        {
            return this.CalculateProductPerDay();
        }

        private double CalculateProductPerDay()
        {
            switch (this.age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
    }
}
