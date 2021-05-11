using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaEx1
{
    public class Dough
    {
        //2cal per 1gram
        private string flourType;//White - 1,5 ,Wholegrain - 1.0
        private string bakingTechnique;//Crispy - 0.9,Chewy - 1.1, Homemade - 1.0
        private double doughWeight;
        private double cals;
        private double flourM;
        private double bakingM;

        public Dough(string flourType, string bakingTechnique , double doughWeight)
        {
            this.FlourType = flourType.ToLower();
            this.BakingTechnique = bakingTechnique.ToLower();
            this.DoughWeight = doughWeight;
        }

        public string FlourType
        {
            get { return flourType; }
            private set
            {
                if(value.Equals("white") || value.Equals("wholegrain"))
                {
                    flourType = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }
        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set
            {
                if (value.Equals("crispy") || value.Equals("chewy")|| value.Equals("homemade"))
                {
                    bakingTechnique = value;
                }
                else
                {
                    throw new ArgumentException("Invalid technique.");
                }
                
            }
        }
        public double DoughWeight
        {
            get { return doughWeight; }
            private set
            {
                if(value <= 0 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200]");
                }
                doughWeight = value;
            }
        }


        public double GetDoughCals()
        {
            switch (this.flourType)
            {
                case "white":
                    this.flourM = 1.5;
                    break;
                case "wholegrain":
                    this.flourM = 1.0;
                    break;
            }
            switch (this.bakingTechnique)
            {
                case "crispy":
                    this.bakingM = 0.9;
                    break;
                case "chewy":
                    this.bakingM = 1.1;
                    break;
                case "homemade":
                    this.bakingM = 1.0;
                    break;
            }
            this.cals = (2 * doughWeight) * flourM * bakingM;
            return this.cals;
        }
    }
}
