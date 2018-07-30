using StorageMaster.Entities.Products;
using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Entities.Storages
{
    public abstract class Storage
    {
        private readonly List<Product> products;
        private readonly Vehicle[] garage;

        public Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;

            this.garage = new Vehicle[garageSlots];
            this.products = new List<Product>();

            InitalizeGarage(vehicles);
        }

        public string Name { get; }

        public int Capacity { get; }

        public int GarageSlots { get; }

        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(this.garage);

        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();


        public bool IsFull => Capacity <= this.products.Sum(p => p.Weight);

        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= this.GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }

            var vehicle = this.garage[garageSlot];
            if (vehicle == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }

            return vehicle;
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = GetVehicle(garageSlot);
            if (deliveryLocation.GarageSlots <= deliveryLocation.Garage.Count || deliveryLocation.Garage.Any(v => v == null))
            {
                throw new InvalidOperationException("No room in garage!");
            }
            this.garage[garageSlot]=null;
         var destSlot = Array.IndexOf(deliveryLocation.garage, null);
            deliveryLocation.garage[destSlot]= vehicle;
            return destSlot;
        }

        public int UnloadVehicle(int garageSlot)
        {
            int count = 0;
            if (this.IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }
            Vehicle vehicle = GetVehicle(garageSlot);
            foreach (var item in vehicle.Trunk)
            {
                if (!this.IsFull)
                {
                    Product product = vehicle.Unload(item);
                    this.products.Add(product);
                    count++;
                }
            }
            return count;
        }
        private void InitalizeGarage(IEnumerable<Vehicle> vehicles)
        {
            foreach (var item in vehicles)
            {
                this.garage.Add(item);
            }
        }
    }
}
