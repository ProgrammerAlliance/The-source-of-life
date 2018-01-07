using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string GetString(double number)
        {
            result = "sqr(" + number + ")";
            return result;
        }
    }
}
