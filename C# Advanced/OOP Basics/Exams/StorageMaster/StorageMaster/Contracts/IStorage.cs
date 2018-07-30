using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Contractss
{
    public interface IStorage
    {
        string Name { get; }

        int Capacity { get; }

        int GarageSlots { get; }

        IReadOnlyCollection<IVehicle> Garage { get; }

        IReadOnlyCollection<IProduct> Products { get; }
    }
}
