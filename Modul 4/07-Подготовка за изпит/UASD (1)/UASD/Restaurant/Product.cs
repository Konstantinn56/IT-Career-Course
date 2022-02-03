using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Product
    {
        private string name;
        private Product next;

        public Product(string name)
        {
            this.Name = name;
        }
        public Product Next
        {
            get { return next; }
            set { next = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public override string ToString()
        {
            return $"Product {this.Name}";
        }
    }
}
