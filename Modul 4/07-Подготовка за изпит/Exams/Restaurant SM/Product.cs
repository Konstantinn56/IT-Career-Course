using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_SM
{
    public class Product
    {
        private string name;
        private Product next;

        public Product(string name)
        {
            this.Name = name;
            this.Next = null;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Product Next
        {
            get { return next; }
            set { next = value; }
        }

        public override string ToString()
        {
            return $"Product {this.Name}";
        }
    }
}
