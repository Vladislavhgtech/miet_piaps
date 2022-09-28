using miet_piaps_lab1.BoardAnyCarClasses;
using miet_piaps_lab1.DriverClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace miet_piaps_lab1.AbstractFactory
{
    interface IStationAbstractFactory
    {
        BoardAnyCar BoardAnyCar();
        Driver CreateDriver();
    }
}
