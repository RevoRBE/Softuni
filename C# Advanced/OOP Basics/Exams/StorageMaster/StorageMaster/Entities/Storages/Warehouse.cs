using System.Collections.Generic;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storages
{
    class Warehouse : Storage
    {
        private const int capacity = 10;
        private const int garageSlots = 10;
        static private IEnumerable<Vehicle> vehicles => new List<Vehicle>
        {
           new Semi(),
           new Semi(),
           new Semi()
        };
        public Warehouse(string name) : base(name, capacity, garageSlots, vehicles)
        {
        }
    }
}
