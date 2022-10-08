using System;
using System.Collections.Generic;
using System.Text;

namespace miet_piaps_lab2
{
    // управление созданием транспортом
    public class Director
    {
        public Transport createTransport(TransportBuilder builder)
        {
            builder.createTransport();
            builder.buildDriver();
            builder.buildGrownUp();
            builder.buildLgotn();
            builder.buildChild();
            builder.buildChairs();
            builder.buildWillGo();
            builder.buildPrice();
            return (builder.getTransport());
        }
    }
}
