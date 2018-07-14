using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Models.Benders
{
    class AirBender:Bender
    {
        private double aerialIntegrity;

        public double AerialIntegrity
        {
            get { return aerialIntegrity; }
            protected set { aerialIntegrity = value; }
        }

        public AirBender(string name, int power, double aerialIntegrity):base(name,power)
        {
            this.AerialIntegrity = aerialIntegrity;
        }

        public override double GetBenderTotalPower()
        {
            return this.Power * this.AerialIntegrity;
        }
    }
}
