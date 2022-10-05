using System;
using System.Collections.Generic;
using System.Text;

namespace miet_piaps_lab2
{
    abstract class StationBuilder
    {
        protected static readonly Random rnd = new Random();
        protected Station station;

        public virtual void CreateStation() { }

        public virtual void CreateBuses() { }

        public virtual void CreateTaxies() { }

        public virtual void CreateDrivers() { }

        public virtual void CreateExtraEquipment() { }

        public virtual void CreateMaturePassengers() { }

        public virtual void CreateChildPassengers() { }

        public virtual void CreateLgotnyPassengers() { }

        public virtual Station GetStation()
        {
            return station;
        }
    }

}
