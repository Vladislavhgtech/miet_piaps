using miet_piaps_lab1.DriverClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace miet_piaps_lab1.BoardAnyCarClasses
{
    class BoardBus : BoardAnyCar
    {
        public static readonly int passengerPlaces = 29;
        public static readonly int driverPlaces = 1;
        public BoardBus()
        {

        }

        public override int Board(int passengersAmount, Driver driver)
        {
            int boardedPassengers = 0;
            int boardedDrivers = 0;
            boardedDrivers += BoardDriver(driver);
            boardedPassengers += BoardPassengers(passengersAmount);

            if (boardedDrivers == 0)
            {
                Console.WriteLine("Cant departure without driver");
            }

            if (boardedPassengers == 0)
            {
                Console.WriteLine("Cant departure without passengers");
            }

            return boardedPassengers + boardedDrivers;
        }

        public override int BoardDriver(Driver driver)
        {
            if (driver == null)
                return 0;
            else
            {
                Console.WriteLine(driver);
            }
            return 1;
        }

        public override int BoardPassengers(int amount)
        {
            int boardedPassengers = 0;
            if (amount <= BoardBus.passengerPlaces)
                boardedPassengers = amount;
            else
                boardedPassengers = BoardBus.passengerPlaces;

            Console.WriteLine("passengers boarded:");
            for (int i = 0; i < boardedPassengers; i++)
                Console.Write((new Passenger()).ToString() + " ");
            Console.WriteLine();
            if (amount - boardedPassengers != 0)
            {
                Console.WriteLine("Bus is filled, cant board more");
            }

            return boardedPassengers;
        }
    }
}
