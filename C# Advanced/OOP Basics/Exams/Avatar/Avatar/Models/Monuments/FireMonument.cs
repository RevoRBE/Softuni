using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Models.Benders
{
    class FireMonument:Monument
    {
        private int fireAffinity;

        public int FireAffinity
        {
            get { return fireAffinity; }
            protected set { fireAffinity = value; }
        }

         public FireMonument(string name,  int fireAffinity):base(name)
        {
            this.FireAffinity = fireAffinity;
        }
    }
}
