using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam
{
    public class VendingMachine
    {
        private string id;
        private List<Product> products;
        private double totalSalesAmount;//default = 0;
        private double battery;//default = 100;
        private int totalSalesCounter = 0;
        
        public VendingMachine(string id)
        {
            this.Id = id;
            this.Products = new List<Product>();
            this.TotalSalesAmount = 0.0;
            this.Battery = 100;
        }
        public VendingMachine(string id, List<Product> products): this(id)
        {
            this.Products = products;
        }


        public string Id
        {
            get { return id; }
            private set 
            {
                if (value.ToLower().Equals(value) && value.Length > 3)
                {
                    id = value;
                }
                else
                    throw new ArgumentException("Invalid machine id!");
            }
        }
        public List<Product> Products
        {
            get { return products; }
            private set { products = value; }
        }
        public double TotalSalesAmount
        {
            get { return totalSalesAmount; }
            private set { totalSalesAmount = value; }
        }
        public double Battery
        {
            get { return battery; }
            private set { battery = value; }
        }
        public int TotalSalesCounter
        {
            get { return totalSalesCounter; }
            private set
            {
                totalSalesCounter = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Machine: {this.Id} has the following available products:");
            foreach ( var p in this.Products)
            {
                sb.AppendLine($"Product with type - {p.Type} and name - {p.Name}");
            }
            sb.AppendLine($"---- With total sales amount: {this.TotalSalesAmount:f2}.");
            return sb.ToString();
        }

        public void Recharge()
        {
            this.Battery = 100;
        }
        public void ClearSales()
        {
            this.TotalSalesAmount = 0.0;
        }
        public void AddProduct(Product product)
        {
            this.Products.Add(product);
            product.Quantity++;
        }

        public int CheckProductQuantityOfGivenType(string type)
        {
            int counter = 0;
            foreach (var p in products.Where(p => p.Type.Equals(type)))
            {
                counter++;
            }
            return counter;
        }
        public void RemoveProduct(string name)
        {
            Product product = products.Where(n => n.Name.Equals(name)).FirstOrDefault();
            if(product == null)
            {

            }
            else
                products.Remove(product);
        }
        public Product GetMostExpensiveProduct()
        {
            Product product = products.OrderByDescending(p => p.Price).FirstOrDefault();
            return product;
        }

        public string SellProduct(string name)
        {
            Product productForSale = products.Where(n => n.Name.Equals(name)).FirstOrDefault();
            double batteryNeeded = productForSale.Price * 0.8 + 2;
            if (productForSale != null && this.Battery > batteryNeeded)
            {
                this.Battery -= batteryNeeded;
                this.TotalSalesAmount += productForSale.Price;

                productForSale.Quantity--;
                this.TotalSalesCounter++;

                products.Remove(productForSale);
                return $"{productForSale.Name} for {productForSale.Price}";
            }
            throw new ArgumentException("Out of battery!");
            
        }

        public void RemoveAllProductsOfGivenType(string type)
        {
            foreach (var p in products.Where(t => t.Type.Equals(type)))
            {
                products.Remove(p);
            }
        }

        public string GetInfoAboutAllProductsByType()
        {
            foreach (var p in products.OrderByDescending(n => n.Name))
            {

            }
        }
    }
}
