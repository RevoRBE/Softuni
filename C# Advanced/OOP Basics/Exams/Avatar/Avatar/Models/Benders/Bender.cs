using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Models.Benders
{
    public abstract class Bender
    {
        private string name;
        private int power;

        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        public int Power
        {
            get { return power; }
            protected set { power = value; }
        }

        public Bender(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }

        public abstract double GetBenderTotalPower();
    }
}