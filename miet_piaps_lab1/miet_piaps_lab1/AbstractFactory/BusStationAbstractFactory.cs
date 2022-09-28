using miet_piaps_lab1.BoardAnyCarClasses;
using miet_piaps_lab1.DriverClasses;
using System;
using System.Collections.Generic;
using System.Text;
using static miet_piaps_lab1.AbstractFactory.IStationAbstractFactory;

namespace miet_piaps_lab1.AbstractFactory
{
    class BusStationAbstractFactory : IStationAbstractFactory
    {
        public BoardAnyCar BoardAnyCar()
        {
            return new BoardBus();
        }

        public Driver CreateDriver()
        {
            return BusDriver.GetNewDriver();
        }

   
    }
}
