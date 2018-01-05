using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class Reciprocal : Special_Operation
    {
        public override object GetResult()
        {
            object result = 0;
            if (NumberA == 0)
            {
                result = "零没有倒数";
            }
            else
            {
                result = 1 / NumberA;
            }
           
            return result;
        }

        public override string GetString()
        {
            return "1/(" + NumberA + ")";
        }
    }
}
