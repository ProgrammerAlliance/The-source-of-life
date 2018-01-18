using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Core.SDK;

namespace Calculator.Core
{

    public class Reciprocal : ISpecialOperation
    {
        public double GetResult(double number)
        {
            double result = 0;
            if (number == 0)
            {
                throw new CalcException("0没有倒数!");
            }
            else
            {
                result = 1 / number;
            }
            return result;
        }


        public string GetToString(string num)
        {
            return $"reciproc({num})";

        }
    }
}