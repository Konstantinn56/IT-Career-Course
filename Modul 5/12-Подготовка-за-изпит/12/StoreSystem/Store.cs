using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem
{
    public class Store
    {
        private string name;
        private string type;
        private double revenue;
        private List<Product> products;
        /////////////////////////////////////////////////////////////////////////////////

        public Store(string name, string type)
        {
            this.Name = name;
            this.Type = type;
            products = new List<Product>();
        }
        /////////////////////////////////////////////////////////////////////////////////
        
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Store name must not be null or empty!");
                }
                name = value; 
            }
        }
        public string Type
        {
            get { return type; }
            private set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Store type must not be null or empty!");
                }
                type = value; 
            }
        }
        public double Revenue
        {
            get { return revenue; }
            private set { revenue = value; }
        }
        /////////////////////////////////////////////////////////////////////////////////
        
        public Product GetProduct(string name)
        {
            return this.products.Where(p => p.Name.Equals(name)).FirstOrDefault();
        }
        public bool ReceiveProduct(Product product)
        {
            if (GetProduct(product.Name) == null)
            {
                this.products.Add(product);
                return true;
            }
            return false;
        }
        public bool SellProduct(string name, int quantity)
        {
            Product product = GetProduct(name);
            if (product !=null && product.Quantity >= quantity)
            {
                product.ChangeQuantity(quantity);
                if (product.Quantity == 0)
                {
                    this.products.Remove(product);
                }
                this.Revenue += quantity * product.FinalPrice;
                return true;
            }
            return false;
            
        }
        /////////////////////////////////////////////////////////////////////////////////
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****Store: {this.Name} <{this.Type}>");
            sb.Append($"****Available products: <{this.products.Count}>");
            foreach (Product product in products)
            {
                sb.AppendLine();
                sb.Append($"****** {product.Name} ({product.Quantity})");
            }
            sb.AppendLine();
            sb.Append($"****Revenue: <{this.Revenue:f2}BGN>");
            return sb.ToString();
        }
    }
}
