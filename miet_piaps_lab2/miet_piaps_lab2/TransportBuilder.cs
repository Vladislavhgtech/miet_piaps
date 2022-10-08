using System;
using System.Collections.Generic;
using System.Text;

namespace miet_piaps_lab2
{
    public class TransportBuilder
    {
        protected Transport tr;
        protected Random rnd = new Random();
        public virtual Transport getTransport() { return tr; }
        public virtual void createTransport() { tr = new Transport(); }
        public virtual void buildGrownUp() { }
        public virtual void buildLgotn() { }
        public virtual void buildChild() { }
        public virtual void buildChairs() { }
        public void buildDriver()
        {
            if (rnd.Next(2) > 0)
                tr.transDriver = "TaxiDriver";
            else
                tr.transDriver = "BusDriver";
        }
        public virtual void buildWillGo() { }
        public virtual void buildPrice()
        {
            tr.price = rnd.Next(200, 5000);
        }
    }
}
