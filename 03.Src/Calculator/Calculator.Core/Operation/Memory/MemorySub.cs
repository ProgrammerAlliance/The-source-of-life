using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Operation
{
    class MemorySub : IMemory
    {
        public void Process(double result, double number)
        {
            number -= result;
        }
    }
}
