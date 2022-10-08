using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace miet_piaps_lab2
{
    public class Transport
    {
        public List<GrownUp> guList = new List<GrownUp>();
        public List<Lgotn> lgList = new List<Lgotn>();
        public List<Child> clList = new List<Child>();
        public int nuberOfChildChairs;
        public String transDriver;
        public bool willgo;
        public int price;

        public void info()
        {
            foreach (GrownUp i in guList)
                i.info();
            foreach (Lgotn i in lgList)
                i.info();
            foreach (Child i in clList)
                i.info();
            Console.WriteLine("Водитель " + transDriver);
            if (willgo)
            {
                Console.WriteLine("Поедет");
                Console.WriteLine("За проезд заплатят " + price + " рублй");
            }
            else
                Console.WriteLine("Не поедет");

        }
    }
}
