using Calculator.Core.Opt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class OperationSub : IOperation
    {
        public double GetResult(double number1, double number2)
        {
            double result = 0;
            result = number1 - number2;
            return result;
        }

        public string ToString(string number1, string number2)
        {
            throw new NotImplementedException();
        }
    }
}
