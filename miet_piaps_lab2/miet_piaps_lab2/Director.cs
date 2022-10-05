using System;
using System.Collections.Generic;
using System.Text;

namespace miet_piaps_lab2
{
    class Director
    {
        private StationBuilder builder;
        public Director(StationBuilder builder)
        {
            this.builder = builder;
        }

        public Station CreateStation()
        {
            builder.CreateStation();
            builder.CreateBuses();
            builder.CreateTaxies();
            builder.CreateDrivers();
            builder.CreateExtraEquipment();
            builder.CreateMaturePassengers();
            builder.CreateChildPassengers();
            builder.CreateLgotnyPassengers();

            return builder.GetStation();
        }

        public void SetStationBuilder(StationBuilder builder)
        {
            this.builder = builder;
        }
    }
}
