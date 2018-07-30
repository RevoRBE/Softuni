using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storages
{
    class AutomatedWarehouse : Storage
    {
        private const int capacity = 1;
        private const int garageSlots = 2;
        static private IEnumerable<Vehicle> vehicles => new List<Vehicle>
        {
           new Truck()
        };
        public AutomatedWarehouse(string name) : base(name, capacity, garageSlots, vehicles)
        {
        }
    }
}
