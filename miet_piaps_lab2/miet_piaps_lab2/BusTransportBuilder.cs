using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace miet_piaps_lab2
{
    public class BusTransportBuilder : TransportBuilder
    {
        public override void buildGrownUp()
        {
            for (int i = 0; i < rnd.Next(15); i++)
                tr.guList.Add(new GrownUp());
        }
        public override void buildLgotn()
        {
            for (int i = 0; i < rnd.Next(15); i++)
                tr.lgList.Add(new Lgotn());
        }
        public override void buildChild()
        {
            for (int i = 0; i < rnd.Next(15); i++)
                tr.clList.Add(new Child());
        }
        public override void buildWillGo()
        {
            if (tr.lgList.Count() + tr.clList.Count() + tr.guList.Count() > 30
                || tr.transDriver != "BusDriver" || tr.clList.Count() + tr.guList.Count == 0)
                tr.willgo = false;
            else
                tr.willgo = true;
        }
        public override void buildPrice()
        {
            tr.price = tr.guList.Count() * 25 + tr.lgList.Count() * 10 + tr.clList.Count() * 5;
        }
    }
}
