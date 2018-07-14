using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Models.Benders
{
    public abstract class Monument
    {
        private string name;
        private int power;

        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        public Monument(string name)
        {
            this.Name = name;
        }
    }
}
