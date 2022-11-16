using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miet_piaps.Lab5.Interpreter.Models
{
    interface IAbstractExpressionInterpreter
    {
        String Interpret(String context);
    }
}
