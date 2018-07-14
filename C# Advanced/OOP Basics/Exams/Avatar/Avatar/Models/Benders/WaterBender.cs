using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Models.Benders
{
    class WaterBender:Bender
    {
         private double waterClarity;

        public double WaterClarity
        {
            get { return waterClarity; }
            protected set { waterClarity = value; }
        }

        public WaterBender(string name, int power, double waterClarity):base(name,power)
        {
            this.WaterClarity = waterClarity;
        }

        public override double GetBenderTotalPower()
        {
                                    return this.Power * this.WaterClarity;

        }
    }
}
