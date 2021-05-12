using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaEx1
{
    public class Pizza
    {
        private string name;
        private int toppingsCount;
        private double cals;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name,int toppingsCount)
        {
            this.Name = name;
            this.ToppingsCount = toppingsCount;
            toppings = new List<Topping>();
        }
        public string Name
        {
            get { return name; }
            private set 
            { 
                if(string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException($"Pizza name should be between 1 and 15 symbols.");
                }
                else
                    name = value;
            }
        }
        public int ToppingsCount
        {
            get { return toppingsCount; }
            private set 
            { 
                if(value < 0 || value > 15)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                else
                    toppingsCount = value;

            }
        }

        public void AddTopping(Topping topping)
        {
            toppings.Add(topping);
        }
        public void AddDough(Dough dough)
        {
            this.dough = dough;
        }

        public double GetCals()
        {
            double cals = this.dough.GetDoughCals();

            foreach (var t in this.toppings)
            {
                cals += t.GetToppingCals();
            }
            return cals;
        }
        public override string ToString()
        {
            return $"{this.Name} - {GetCals():f2} Calories.";
        }
    }
}
