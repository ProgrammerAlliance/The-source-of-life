using Calculator.Core.Opt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class OperationSub : Operation
    {
        public double GetResult(double number1, double number2)
        {
            double result = 0;
            result = number1 - number2;
            return result;
        }
    }
}
