using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miet_piaps_lab3
{
    abstract class Unit
    {
        protected List<Unit> parts;
        protected static Random rnd = new Random();
        protected int weight = 0;
        public virtual int getLuggageWeight()
        {
            throw new NotImplementedException();
        }

        public virtual void addUnit(Unit unit)
        {
            throw new NotImplementedException();
        }

        public virtual void removeUnit(int index)
        {
            throw new NotImplementedException();
        }

        public virtual void denyUnit(int index)
        {
            throw new NotImplementedException();
        }
    }
}
