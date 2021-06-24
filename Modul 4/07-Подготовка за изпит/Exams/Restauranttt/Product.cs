using System;
using System.Collections.Generic;
using System.Text;

namespace Restauranttt
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
            get
            {
                return name;
            }
            private set
            {
                this.name = value;
            }
        }
        public Product Next 
        {
            get
            {
                return next;
            }
            set
            {
                this.next = value;
            } 
        }


        public override string ToString()
        {
            return $"Product {this.Name}";
        }
    }
}
