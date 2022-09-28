using miet_piaps_lab1.DriverClasses;
using System;
using System.Collections.Generic;
using System.Text;


namespace miet_piaps_lab1.BoardAnyCarClasses
{
    abstract class BoardAnyCar
    {
        public abstract int Board(int passengersAmount, Driver driver);
        public abstract int BoardDriver(Driver driver);
        public abstract int BoardPassengers(int amount);
    }
}
