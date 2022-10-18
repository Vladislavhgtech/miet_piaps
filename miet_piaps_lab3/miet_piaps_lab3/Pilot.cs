using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miet_piaps_lab3
{
    class Pilot : Unit
    {
        public static readonly int passengerAmountLimit = 2;
        public Pilot()
        {
            weight = 0;
        }
        public override int getLuggageWeight()
        {
            return weight;
        }
    }
}
