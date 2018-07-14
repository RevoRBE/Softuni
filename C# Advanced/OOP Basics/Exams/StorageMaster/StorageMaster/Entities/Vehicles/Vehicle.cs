using System;
using System.Collections.Generic;
using System.Linq;
using StorageMaster.Entities.Products;

namespace StorageMaster.Entities.Vehicles
{
    public abstract class Vehicle
    {
        private int capacity;
        private readonly List<Product> trunk;

        protected Vehicle(int capacity)
        {
            this.capacity = capacity;
            this.trunk = new List<Product>();
        }

        public int Capacity { get; }

        public IReadOnlyCollection<Product> Trunk => this.trunk.AsReadOnly();

        public bool IsFull => this.Trunk.Sum(p => p.Weight) >= this.Capacity;

        public bool IsEmpty => !this.Trunk.Any();

        public void LoadProduct(Product product)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            this.trunk.Add(product);
        }

        public Product Unload(Product product)
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            Product lastProduct = this.Trunk.Last();
            this.trunk.Remove(lastProduct);
            return lastProduct;
        }
    }
}
