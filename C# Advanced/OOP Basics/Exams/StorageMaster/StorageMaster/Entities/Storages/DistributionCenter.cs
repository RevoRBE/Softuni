
using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storages
{
    class DistributionCenter : Storage
    {
        private const int capacity = 2;
        private const int garageSlots = 5;
        static private IEnumerable<Vehicle> vehicles => new List<Vehicle>
        {
           new Van(),
           new Van(),
           new Van()
        };
        public DistributionCenter(string name) : base(name, capacity, garageSlots, vehicles)
        {
        }
    }
}
