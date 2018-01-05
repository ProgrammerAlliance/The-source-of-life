using Calculator.Core.Opt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
   public  class OperationAdd:Operation
    {
        public override object GetResult()
        {
            object result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }
}
