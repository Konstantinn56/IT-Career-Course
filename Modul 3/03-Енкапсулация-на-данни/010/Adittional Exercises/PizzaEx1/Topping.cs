using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaEx1
{
    public class Topping
    {
        //2 cals per 1gram
        private string toppingType;//Meat -1.2/Veggies 0.8 /Cheese 1.1/Sauce 0.9
        private double toppingWeight;
        private double toppingM;

        public Topping(string toppingType,double toppingWeight)
        {
            this.ToppingType = toppingType.ToLower();
            this.ToppingWeight = toppingWeight;
        }


        public string ToppingType
        {
            get { return toppingType; }
            private set 
            {
                if (value.Equals("meat") || value.Equals("veggies") || value.Equals("cheese") || value.Equals("sauce"))
                {
                    toppingType = value;
                }
                else
                    throw new ArgumentException($"Cannot place {value} on top of your pizza");
            }
        }
        public double ToppingWeight
        {
            get { return toppingWeight; }
            private set 
            {
                if (value > 0 && value <= 50)
                {
                    toppingWeight = value;
                }
                else
                    throw new ArgumentException($"{this.toppingType} weight should be in the range [1..50].");
            }
        }

        public double GetToppingCals()
        {
            switch (this.ToppingType)
            {
                case "meat":
                    this.toppingM = 1.2;
                    break;
                case "veggies":
                    this.toppingM = 0.8;
                    break;
                case "cheese":
                    this.toppingM = 1.1;
                    break;
                case "sauce":
                    this.toppingM = 0.9;
                    break;
            }
            double cals = (2*this.ToppingWeight) * this.toppingM;
            return cals;
        }
    }
}
