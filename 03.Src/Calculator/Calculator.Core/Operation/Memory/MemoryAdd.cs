using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Operation.Memory
{
    class MemoryAdd : IMemory
    {
        public void Process(double result,double number)
        {
            number += result;
        }
    }
}
