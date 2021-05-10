using System;
using System.Collections.Generic;
using System.Text;

namespace Ex4
{
    public class Product
    {
        private string name;
        private string barcode;
        private double price;
        private double quantity;

        public Product(string name,string barcode, double price, double quantity)
        {
            this.Name = name;
            this.Barcode = barcode;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public string Barcode
        {
            get { return barcode; }
            private set { barcode = value; }
        }
        public double Price
        {
            get { return price; }
            private set { price = value; }
        }
        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public override string ToString()
        {
            return $"{this.Name} ({this.Barcode})";
        }
    }
}
