using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Contractss
{
    public interface IVehicle
    {
        int Capacity { get; }

        IReadOnlyCollection<IProduct> Trunk { get; }

        bool IsFull();

        bool IsEmpty();
    }
}
