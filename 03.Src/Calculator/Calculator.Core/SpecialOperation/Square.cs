using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class Square:ISpecialOperation
    {
        public double GeResult(double number)
        {
            double result = 0;
            result = number * number;
            return result;

        }

        public string GetString(double number)
        {
            string result = "sqr(" + number + ")";
            return result;
        }
    }
}
