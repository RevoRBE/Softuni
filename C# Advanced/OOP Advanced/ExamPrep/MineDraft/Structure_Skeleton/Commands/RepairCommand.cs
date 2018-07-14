using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minedraft.Commands
{
    public class RepairCommand : Command
    {
        private IProviderController providerController;
        private RepairCommand(IList<string> args, IProviderController providerController) : base(args)
        {
            this.providerController = providerController;
        }

        public override string Execute()
        {
            double val = double.Parse(this.Arguments[0]);
            return this.providerController.Repair(val);
        }
    }
}
