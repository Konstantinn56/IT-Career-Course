using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4
{
    public static class StoreController
    {
        private static List<Product> products = new List<Product>();

        public static void Add(string barcode,string name,double quantity, double price)
        {
            Product product = new Product(name, barcode, price, quantity);
            products.Add(product);
        }
        public static string Sell(string barcode, double quantity)
        {
            Product product = GetProductByBarcode(barcode);
            if (product == null || product.Quantity < quantity)
            {
                return "Not enough quantity";
            }
            product.Quantity -= quantity;
            return $"{product.Name} was selled";
        }
        public static string Update(string barcode, double quantity)
        {
            Product product = GetProductByBarcode(barcode);
            if(product == null)
            {
                return "Please add your product first!";
            }
            product.Quantity += quantity;
            return $"Product {product.Name} was updated";
        }
        public static void PrintA()
        {
            foreach (var p in products.OrderBy(n => n.Name))
            {
                Console.WriteLine(p);
            }
        }
        public static void PrintU()
        {
            foreach (var p in products.Where(q => q.Quantity == 0).OrderBy(q => q.Name))
            {
                Console.WriteLine(p);
            }
        }
        public static void PrintD()
        {
            foreach (var p in products.OrderByDescending(q => q.Quantity))
            {
                Console.WriteLine(p);
            }
        }
        public static double Calculate()
        {
            return products.Where(p => p.Quantity > 0).Sum(p => (p.Price * p.Quantity));
        }
        private static Product GetProductByBarcode(string barcode)
        {
            return products.Where(b => b.Barcode.Equals(barcode)).FirstOrDefault();
        }
    }
}
