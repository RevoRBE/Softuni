using StorageMaster.Entities.Storages;
using System;

namespace Logger.Models.Factories
{
    public class StorageFactory
    {
        public Storage CreateStorage(string storageType, string name)
        {
            Storage storage = null;
            switch (storageType)
            {
                case "AutomatedWarehouse":
                    storage = new AutomatedWarehouse(name);
                    break;
                case "DistributionCenter":
                    storage = new DistributionCenter(name);
                    break;
                case "Warehouse":
                    storage = new Warehouse(name);
                    break;
                default:
                    throw new InvalidOperationException("Ivalid storage type");
            }
            return storage;
        }
    }
}
