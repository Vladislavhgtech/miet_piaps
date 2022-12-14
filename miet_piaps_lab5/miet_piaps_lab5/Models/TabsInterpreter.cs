using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace miet_piaps.Lab5.Interpreter.Models
{
    class TabsInterpreter : IAbstractExpressionInterpreter
    {
        public string Interpret(string context)
        {
            context = (new Regex("( \t)+")).Replace(context, "\t");
            context = (new Regex("(\t )+")).Replace(context, "\t");
            context = (new Regex("\t+")).Replace(context, "\t");
            context = (new Regex("[ \t]+\n+")).Replace(context, "\n");

            return context;
        }
    }
}
