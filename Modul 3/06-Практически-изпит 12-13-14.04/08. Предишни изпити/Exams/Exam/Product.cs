using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    public class Product
    {
        private string type;
        private string name;
        private double price;
        private int totalSales = 0;
        private int quantity = 0;

        
        public Product(string type, string name,double price)
        {
            this.Type = type;
            this.Name = name;
            this.Price = price;
        }

        

        public string Type
        {
            get { return type; }
            private set 
            {
                if (value.ToUpper().Equals(value))
                {
                    type = value;
                }
                else
                    throw new ArgumentException("Invalid type!");
            }
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length > 2)
                {
                    name = value;
                }
                else
                    throw new ArgumentException("Invalid name!");
            }
        }
        public double Price
        {
            get { return price; }
            private set 
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                    throw new ArgumentException("Invalid price!");
            }
        }
        
        public int TotalSales
        {
            get { return totalSales; }
            set { totalSales = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public override string ToString()
        {
            return $"Product with type - {this.Type} and name - {this.Name}";
        }

       
    }
}
