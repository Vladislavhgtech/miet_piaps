using System;
using System.Collections.Generic;
using System.Text;

namespace miet_piaps_lab1.DriverClasses
{
    abstract class Driver
    {
        public int experience;
        public String name;
        public int id;
        protected static Random rnd = new Random();
    }
}
