using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Save
{
    class Memory
    {
        List<double> MemoryNumber = new List<double>();

        public void MemorySave(double num)
        {
            if (num != 0)
            {
                MemoryNumber.Add(num);
            }
        }

        public double MemoryRead()
        {
            return MemoryNumber[1];
        }

        public void MemoryClean()
        {

        }
    }
}
