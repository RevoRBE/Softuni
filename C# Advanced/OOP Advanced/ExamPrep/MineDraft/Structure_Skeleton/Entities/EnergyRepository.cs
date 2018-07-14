using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minedraft.Entities
{
    class EnergyRepository : IEnergyRepository
    {
        public double EnergyStored {get; private set;}

        public void StoreEnergy(double energy)
        {
            this.EnergyStored+=energy;
        }

        public bool TakeEnergy(double energyNeeded)
        {
            if (energyNeeded >=this.EnergyStored)
            {
                this.EnergyStored-=energyNeeded;
                return true;
            }
                return false;
        }
    }
}
