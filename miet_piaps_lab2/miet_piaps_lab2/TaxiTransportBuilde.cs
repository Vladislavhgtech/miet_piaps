using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace miet_piaps_lab2
{
    public class TaxiTransportBuilder : TransportBuilder
    {
        public override void buildChairs() { tr.nuberOfChildChairs = rnd.Next(2); }
        public override void buildChild()
        {
            for (int i = 0; i < rnd.Next(1); i++)
                tr.clList.Add(new Child());
        }
        public override void buildGrownUp()
        {
            for (int i = 0; i < rnd.Next(4); i++)
                tr.guList.Add(new GrownUp());
        }
        public override void buildWillGo()
        {
            if (tr.clList.Count() > tr.nuberOfChildChairs || tr.clList.Count() + tr.guList.Count() > 4
                || tr.transDriver != "TaxiDriver" || tr.clList.Count() + tr.guList.Count == 0)
                tr.willgo = false;
            else
                tr.willgo = true;
        }
    }
}
