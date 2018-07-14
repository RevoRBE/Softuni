using Logger.Models.Factories;
using StorageMaster.Entities.Products;
using StorageMaster.Entities.Storages;
using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace StorageMaster.Core
{
    public class StorageMaster
    {
        private ICollection<Product> productPool;
        private ICollection<Storage> storageRegistry;

        private readonly ProductFactory productFactory;
        private readonly StorageFactory storageFactory;
        private readonly VehicleFactory vehicleFactory;

        private Vehicle currentVehicle;
        public StorageMaster()
        {
            this.productFactory = new ProductFactory();
            this.storageFactory = new StorageFactory();
            this.vehicleFactory = new VehicleFactory();
            this.storageRegistry = new Collection<Storage>();
            this.productPool = new Collection<Product>();
        }

        public string AddProduct(string type, double price)
        {
            Product product = productFactory.CreateProduct(type, price);
            productPool.Add(product);
            return $"Added {type} to pool";
        }

        public string RegisterStorage(string type, string name)
        {
            Storage storage = storageFactory.CreateStorage(type, name);
            storageRegistry.Add(storage);
            return $"Registered {name}";
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            Storage storage = (Storage)this.storageRegistry.FirstOrDefault(s => s.Name == storageName);
            if (storageRegistry == null)
                throw new InvalidOperationException("Invalid storage!");
            currentVehicle = storage.GetVehicle(garageSlot);
            return $"Selected {currentVehicle.GetType().Name}";
        }
        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int loadedProductsCount = 0;
            foreach (var product in productNames)
            {
                if (!productPool.Any(p => p.GetType().Name == product))
                {
                    throw new InvalidOperationException($"{product} is out of stock!");
                }
                else
                {
                    Product current = (Product)productPool.Last(p => p.GetType().Name == product);
                    productPool.Remove(current);
                    currentVehicle.LoadProduct(current);
                    loadedProductsCount++;
                }
            }
            return $"Loaded {productNames.Count()}/{loadedProductsCount} products into {currentVehicle.GetType().Name}";
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            var currentStorage = (Storage)this.storageRegistry.First(n => n.Name == sourceName);
            var destinationGarageSlot = currentStorage.SendVehicleTo(sourceGarageSlot, currentStorage);
            return $"Sent {currentVehicle.GetType().Name} to {destinationName} (slot {destinationGarageSlot})";
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            int unloadedProductsCount = 0;

             var currentStorage = (Storage)this.storageRegistry.First(n => n.Name == storageName);
            if (currentStorage.IsFull)
            {

            }
             var vehicle = (Vehicle)currentStorage.Garage.ElementAt(garageSlot);
            foreach (var item in vehicle.Trunk)
            {
                 vehicle.Unload(item);
                unloadedProductsCount++;
            }
            return $"Unloaded {unloadedProductsCount}/{vehicle.Trunk.Count()} products at {storageName}";
        }

        public string GetStorageStatus(string storageName)
        {
            StringBuilder sb = new StringBuilder("Garage: [");
            var currentStorage = (Storage)this.storageRegistry.First(n => n.Name == storageName);
            var totalItemWeight = currentStorage.Products.Sum(p => p.Weight);
            var capacity = currentStorage.Capacity;
            foreach (var item in currentStorage.Products.GroupBy(p => p.GetType().Name).OrderByDescending(g => g.Count()).ThenBy(g => g.Key))
            {
                sb.Append(item.GetType().Name + "|");
            }
            sb.Length--;
            return "";
        }

        public string GetSummary()
        {
            throw new NotImplementedException();
        }

    }
}
