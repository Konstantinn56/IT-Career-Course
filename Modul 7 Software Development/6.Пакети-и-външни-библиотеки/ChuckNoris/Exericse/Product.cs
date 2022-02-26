using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericse
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime Expiry { get; set; }

        public Product(int id, string name, decimal price, int stock, DateTime expiry)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
            this.Expiry = expiry;
        }
    }
}
