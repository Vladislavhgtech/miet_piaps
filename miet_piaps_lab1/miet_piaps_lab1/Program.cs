using miet_piaps_lab1.AbstractFactory;
using miet_piaps_lab1.BoardAnyCarClasses;
using System;

namespace miet_piaps_lab1
{



    class Program
    {
        static BoardAnyCar randomBoard;
        static Random rnd = new Random();
        static IStationAbstractFactory factory;

        static int Board(int passengersAmount)
        {
            int num = rnd.Next(0, 2);
            // СОЗДАНИЕ ФАБРИК И ЗАГРУЗЧИКОВ
            switch (num)
            {
                case 0:
                    factory = new BusStationAbstractFactory();
                    randomBoard = factory.BoardAnyCar();
                    break;
                case 1:
                    factory = new TaxiStationAbstractFactory();
                    randomBoard = factory.BoardAnyCar();
                    break;
            }

            int boardedPassengers = 0;
            int boardedDrivers = 0;
            // СОЗДАНИЕ ВОДИТЕЛЕЙ
            boardedDrivers += randomBoard.BoardDriver(factory.CreateDriver());
            boardedPassengers += randomBoard.BoardPassengers(passengersAmount);

            if (boardedDrivers == 0)
            {
                Console.WriteLine("Cant departure without driver");
            }

            if (boardedPassengers == 0)
            {
                Console.WriteLine("Cant departure without passengers");
            }

            return boardedPassengers;
        }
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Initialize();


            Console.WriteLine(s1.GetHashCode());

            Singleton s2 = Singleton.Initialize();

            Console.WriteLine(s2.GetHashCode());

            /* Программа выводит два одинаковых хэшкода у двух разных объектов, потому что мы присвоили
             одну и ту же ссылку двум разным объектам. Это обстоятельство опредеяет 
            Таким образов в  однопоточном приложении будет единственный экземпляр данного класса*/




            int waitingPassengersAmount = 0;
            Console.WriteLine("How many passengers do you need to board?");
            waitingPassengersAmount = Convert.ToInt32(Console.ReadLine());

            int boardnum = 0;
            while (waitingPassengersAmount > 0)
            {
                boardnum++;
                Console.WriteLine("~BOARD-" + boardnum);
                waitingPassengersAmount -= Board(waitingPassengersAmount);
                Console.WriteLine("~people waiting:" + waitingPassengersAmount + "\n");
            }

            Console.ReadLine();


        }
    }
}
