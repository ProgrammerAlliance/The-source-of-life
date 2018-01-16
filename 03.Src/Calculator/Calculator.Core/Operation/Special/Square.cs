using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Core.SDK;

namespace Calculator.Core
{
    public class Square:ISpecialOperation
    {
        string result = "";

        public double GetResult(double number)
        {
            double result = 0;
            result = number * number;
            return result;
        }

        public string GetToString(string num)
        {
            return "sqr(" + num.ToString() + ")";

        }
    }
}
