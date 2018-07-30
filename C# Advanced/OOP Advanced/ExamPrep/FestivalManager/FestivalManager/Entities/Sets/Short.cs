namespace FestivalManager.Entities.Sets
{
    using FestivalManager.Entities.Contracts;
    using System;

    public class Short : Set
    {
        public Short(string name)
            : base(name, new TimeSpan(0, 0b1111, 0))
        {
        }

    }
}