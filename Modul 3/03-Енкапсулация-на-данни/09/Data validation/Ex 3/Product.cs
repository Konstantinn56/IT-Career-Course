using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_3
{
    public class Product
    {
        private string pName;
        private double price;

        public Product(string name, double price)
        {
            this.PName = name;
            this.Price = price;
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string PName
        {
            get { return pName; }
            set { pName = value; }
        }

        public override string ToString()
        {
            return $"{this.PName}";
        }
    }
}
