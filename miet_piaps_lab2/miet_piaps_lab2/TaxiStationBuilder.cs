using System;
using System.Collections.Generic;
using System.Text;

namespace miet_piaps_lab2
{
    class TaxiStationBuilder : StationBuilder
    {
        public TaxiStationBuilder() { }

        public override void CreateStation()
        {
            base.station = new Station();
        }

        public override void CreateTaxies()
        {
            base.station.taxiesAmount = rnd.Next(0, 10);
        }

        public override void CreateDrivers()
        {
            base.station.driversAmount = rnd.Next(0, 10);
        }

        public override void CreateExtraEquipment()
        {
            base.station.extraEquipmentAmount = rnd.Next(0, 10);
        }

        public override void CreateMaturePassengers()
        {
            base.station.maturePassengersAmount = rnd.Next(0, 500);
        }

        public override void CreateChildPassengers()
        {
            base.station.childPassengersAmount = rnd.Next(0, 250);
        }
    }
}
