using System;
using System.Collections.Generic;
using System.Text;

namespace miet_piaps_lab1
{
    class Passenger
    {
        public static int counter = 0;
        public static List<Passenger> passengers = new List<Passenger>();
        public string name;

        public Passenger()
        {
            counter++;
            this.name = "P" + counter.ToString();
            Passenger.passengers.Add(this);
        }

        public override string ToString()
        {
            return name;
        }
    }
}
