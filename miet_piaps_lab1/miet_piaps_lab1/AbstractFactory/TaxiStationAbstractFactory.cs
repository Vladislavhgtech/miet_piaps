using miet_piaps_lab1.BoardAnyCarClasses;
using miet_piaps_lab1.DriverClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace miet_piaps_lab1.AbstractFactory
{
    class TaxiStationAbstractFactory : IStationAbstractFactory
    {
        public BoardAnyCar BoardAnyCar()
        {
            return new BoardTaxi();
        }

        public Driver CreateDriver()
        {
            return TaxiDriver.GetNewDriver();
        }
    }
}
