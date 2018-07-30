using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Models.Benders
{
   class FireBender:Bender
    {
         private double heatAggression;

        public double HeatAggression
        {
            get { return heatAggression; }
            protected set { heatAggression = value; }
        }

        public FireBender(string name, int power, double heatAggression):base(name,power)
        {
            this.HeatAggression = heatAggression;
        }

        public override double GetBenderTotalPower()
        {
                        return this.Power * this.HeatAggression;

        }
    }
}
