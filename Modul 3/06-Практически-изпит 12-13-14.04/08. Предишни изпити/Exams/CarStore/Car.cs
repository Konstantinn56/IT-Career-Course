using System;
using System.Collections.Generic;
using System.Text;

namespace CarStore
{
    public class Car
    {
        private int number;
        private double price;

        public Car(int number, double price)
        {
            this.Number = number;
            this.Price = price;
        }

        ////////////////////////////////////////////////////////////////////////////
      
        public int Number
        {
            get { return number; }
            private set 
            { 
                number = value; 
            }
        }
        public double Price
        {
            get { return price; }
            private set
            {
                if (value >= 1000)
                {
                    price = value;
                }
                else
                    throw new ArgumentException("Invalid car price!");
            }
        }

        ////////////////////////////////////////////////////////////////////////////

        public override string ToString()
        {
            return $"Car number {this.Number} costs {this.Price}";
        }

        ////////////////////////////////////////////////////////////////////////////
    }
}
