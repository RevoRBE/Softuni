using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Models.Benders
{
    class EarthMonument:Monument
    {
        private int earthAffinity;

        public int EarthAffinity
        {
            get { return earthAffinity; }
            protected set { earthAffinity = value; }
        }

         public EarthMonument(string name,  int earthAffinity):base(name)
        {
            this.EarthAffinity = earthAffinity;
        }
    }
}
