using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem
{
    public abstract class Product
    {
        private string name;
        private int quantity;
        private double deliverPrice;
        private double percentageMarkup;

        /////////////////////////////////////////////////////////////////////////////////

        public Product(string name, int quantity, double deliverPrice, double percentageMarkup)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.DeliverPrice = deliverPrice;
            this.PercentageMarkup = percentageMarkup;
        }

        /////////////////////////////////////////////////////////////////////////////////
        public string Name
        {
            get { return name; }
            private set 
            { 
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Product name must not be null or empty!");
                }
                name = value; 
            }
        }
        public int Quantity
        {
            get { return quantity; }
            private set 
            { 
                if(value <= 0)
                {
                    throw new ArgumentException("Quantity cannot be less or equal to 0!");
                }
                quantity = value; 
            }
        }
        public double DeliverPrice
        {
            get { return deliverPrice; }
            private set 
            { 
                if(value <= 0)
                {
                    throw new ArgumentException("Deliver price cannot be less or equal to 0!");
                }
                deliverPrice = value; 
            }
        }
        public double PercentageMarkup
        {
            get { return percentageMarkup; }
            private set 
            { 
                if(value <= 0)
                {
                    throw new ArgumentException("Percentage markup cannot be less or equal to 0!");
                }//General exception
                if (this.GetType().Name.Equals("Food"))
                {
                    if(value > 100)
                    {
                        throw new ArgumentException("Food percentage markup cannot be above 100%!");
                    }
                }//Class Food exception
                if (this.GetType().Name.Equals("Drink"))
                {
                    if(value > 200)
                    {
                        throw new ArgumentException("Drink percentage markup cannot be above 200%!");
                    }
                }//Class Drink exception
                percentageMarkup = value;
            }
        }
        public double FinalPrice
        {
            get { return this.DeliverPrice + (this.DeliverPrice * this.PercentageMarkup / 100); }
        }
        /////////////////////////////////////////////////////////////////////////////////
        public void ChangeQuantity(int quantity)
        {
            this.Quantity -= quantity;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****Product: {this.Name} <{this.Quantity}>");
            sb.AppendLine($"****Deliver Price: {this.DeliverPrice}");
            sb.AppendLine($"****Percentage Markup: {this.PercentageMarkup}");
            sb.AppendLine($"****Final Price: {this.FinalPrice}");
            return sb.ToString();
        }
    }
}
