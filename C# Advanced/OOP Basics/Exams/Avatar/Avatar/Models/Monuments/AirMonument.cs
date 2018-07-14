using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Models.Benders
{
    class AirMonument:Monument
    {
        private int airAffinity;

        public int AirAffinity
        {
            get { return airAffinity; }
            protected set { airAffinity = value; }
        }

         public AirMonument(string name, int airAffinity):base(name)
        {
            this.AirAffinity = airAffinity;
        }
    }
}
