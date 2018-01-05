using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Opt
{
    class Square:Special_Operation
    {
        public override object GetResult()
        {
            double result = 0;
            result = NumberA* NumberA;
            return result;
        }

        public override string GetString()
        {
            return "Sqr(" + NumberA + ")";
        }
    }
}
