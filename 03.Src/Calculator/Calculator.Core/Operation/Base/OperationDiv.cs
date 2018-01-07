using Calculator.Core.Opt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    /// <summary>
    /// todo: mh
    /// </summary>
    public class OperationDiv : IOperation
    {
        public double GetResult(double number1, double number2)
        {
            double result = 0;

            if (number1 == 0 && number2 == 0)
            {
                throw new Exception("结果未定义!");
            }
            else if (number2 != 0)
            {
                result = number1 / number2;
            }
            else
            {
                throw new Exception("除数不能为零!");
            }
            return result;
        }
    }
}
