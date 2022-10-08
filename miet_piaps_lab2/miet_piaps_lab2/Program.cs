using System;

namespace miet_piaps_lab2
{
    class Program
    {

        static void Main(string[] args)
        {
            Director dir = new Director();
            TaxiTransportBuilder ttb = new TaxiTransportBuilder();
            BusTransportBuilder btb = new BusTransportBuilder();
            Transport taxi = dir.createTransport(ttb);
            Transport bus = dir.createTransport(btb);

            Console.WriteLine("Такси");
            taxi.info();
            Console.WriteLine();
            Console.WriteLine("Автобус");
            bus.info();
            Console.ReadKey();
        }

    }
}
