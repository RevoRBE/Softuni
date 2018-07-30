﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minedraft.Commands
{
    public class DayCommand : Command
    {
        private IHarvesterController harvesterController;
        private IProviderController providerController;

        public DayCommand(IList<string> args, IHarvesterController harvesterController, IProviderController providerController) : base(args)
        {
            this.harvesterController = harvesterController;
            this.providerController = providerController;
        }
        public override string Execute()
        {
            string providersResult = this.providerController.Produce();
            string harvestersResult = this.harvesterController.Produce();
            return providersResult + Environment.NewLine + harvestersResult;
        }

    }
}
