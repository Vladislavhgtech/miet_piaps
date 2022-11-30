using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miet_piaps_lab6
{
    class Report
    {
        public string report;
        public Teacher author;

        public Report(string report, Teacher author)
        {
            this.author = author;
            this.report = report;
        }
    }
}
