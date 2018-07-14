using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minedraft.Commands
{
    public class ShutdownCommand : Command
    {
        private IHarvesterController harvesterController;
        private IProviderController providerController;

        public ShutdownCommand(IList<string> args, IHarvesterController harvesterController, IProviderController providerController) : base(args)
        {
            this.harvesterController = harvesterController;
            this.providerController = providerController;
        }

        public override string Execute()
        {
            var sb = new StringBuilder();
            sb.AppendLine("System Shutdown");
            sb.AppendLine($"Total Energy Stored: {this.providerController.TotalEnergyProduced}");
            sb.AppendFormat(Constants.TotalOreProduced, this.harvesterController.OreProduced);

            return sb.ToString();
        }
    }
}
