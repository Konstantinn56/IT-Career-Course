﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster
{
    public abstract class Vehicle
    {
        private int capacity;
        private List<Product> trunk;

        public Vehicle(int capacity)
        {
            this.Capacity = capacity;
            this.trunk = new List<Product>();
        }
        public int Capacity
        {
            get { return capacity; }
            private set { capacity = value; }
        }

        public IReadOnlyCollection<Product> Trunk { get => this.trunk; }
        public bool IsFull 
        {
            get 
            {
                return this.trunk.Sum(p => p.Weight) >= this.Capacity; 
            }
        }

        public bool IsEmpty
        {
            get { return this.trunk.Count == 0; }
        }

        public void LoadProduct(Product product)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }

            this.trunk.Add(product);
        }

        public Product Unload()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }

            Product lastProduct = this.trunk.LastOrDefault();
            this.trunk.RemoveAt(this.trunk.Count-1);

            return lastProduct;
        }
    }
}
