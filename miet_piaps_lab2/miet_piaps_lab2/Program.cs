using System;

namespace miet_piaps_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            StationBuilder busStationBuilder = new BusStationBuilder();
            Director stationDirector = new Director(busStationBuilder);
            Station busStation = stationDirector.CreateStation();
            Console.WriteLine("BUS " + busStation.ToString());

            StationBuilder taxiStationBuilder = new TaxiStationBuilder();
            stationDirector.SetStationBuilder(taxiStationBuilder);
            Station taxiStation = stationDirector.CreateStation();
            Console.WriteLine("TAXI " + taxiStation.ToString());

            Console.ReadLine();
        }
    }
}
