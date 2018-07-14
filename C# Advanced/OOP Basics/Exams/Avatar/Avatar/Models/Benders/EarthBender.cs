using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Models.Benders
{
    class EarthBender : Bender
    {
        private double groundSaturation;

        public double GroundSaturation
        {
            get { return groundSaturation; }
            protected set { groundSaturation = value; }
        }

        public EarthBender(string name, int power, double groundSaturation):base(name,power)
        {
            this.GroundSaturation = groundSaturation;
        }

        public override double GetBenderTotalPower()
        {
            return this.Power * this.GroundSaturation;
        }
    }
}
