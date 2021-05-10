using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_3
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> bagWithProducts;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            bagWithProducts = new List<Product>();
        }
        
        public string Name
        {
            get { return name; }
            private set 
            { 
                name = value; 
            }
        }
        public double Money
        {
            get { return money; }
            private set 
            { 
                if(value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public void TryBuyProduct(Product product)
        {
            if (this.Money >= product.Price)
            {
                this.BagWithProducts.Add(product);
                this.Money -= product.Price;
                Console.WriteLine($"{this.Name} bought {product.PName}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.PName}");
            }
        }

        public List<Product> BagWithProducts
        {
            get { return bagWithProducts; }
            private set 
            { 
                BagWithProducts = value; 
            }
        }

        public override string ToString()
        {
            if(this.BagWithProducts.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }
             return $"{this.Name} - {string.Join(", ", this.BagWithProducts)}";
        }
    }
}
