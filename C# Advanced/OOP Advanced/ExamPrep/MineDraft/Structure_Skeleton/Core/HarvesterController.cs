using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minedraft.Core
{
    public class HarvesterController : IHarvesterController
    {
        private List<IHarvester> harvesters;
        private IEnergyRepository energyRepository;
        private IHarvesterFactory factory;
        private string mode;

        public HarvesterController(IHarvesterFactory factory, IEnergyRepository energyRepository)
        {
            this.mode = Constants.DefaultMode;
            this.harvesters = new List<IHarvester>();
            
            this.factory = factory;
            this.energyRepository = energyRepository;
        }
        public double OreProduced { get; private set; }

        public IReadOnlyCollection<IEntity> Entities => this.harvesters.AsReadOnly();

        public string ChangeMode(string mode)
        {
            this.mode = mode;
            foreach (var har in this.harvesters)
            {
                har.Broke();
            }            return string.Format(Constants.ModeChange, mode);
        }

        public string Produce()
        {
            //calculate needed energy
            double neededEnergy = 0;
            foreach (var harvester in this.harvesters)
            {
                if (this.mode == "Full")
                {
                    neededEnergy += harvester.EnergyRequirement;
                }
                else if (this.mode == "Half")
                {
                    neededEnergy += harvester.EnergyRequirement * 50 / 100;
                }
                 else if (this.mode == "Energy")
                {
                    neededEnergy += harvester.EnergyRequirement * 0.2;
                }
            }

            //check if we can mine and mine
            double minedOres = 0;
            if (this.energyRepository.TakeEnergy(neededEnergy))
            {
                foreach (var harvester in this.harvesters)
                {
                    minedOres += harvester.Produce();
                }
            }

            //take the mode in mind
            if (this.mode == "Energy")
            {
                minedOres *= 0.2;
            }
            else if (this.mode == "Half")
            {
                minedOres = minedOres * 50 / 100;
            }

            this.OreProduced += minedOres;

            return string.Format(Constants.OreMined, minedOres);

            //double minedOre = 0;
            //foreach (var harvester in this.harvesters)
            //{
            //    minedOre += harvester.OreOutput;
            //}
            //return minedOre.ToString();
        }

        public string Register(IList<string> args)
        {
            var harvester = this.factory.GenerateHarvester(args);
            this.harvesters.Add(harvester);
            return string.Format(Constants.SuccessfullRegistration,
                harvester.GetType().Name);
        }
    }
}
