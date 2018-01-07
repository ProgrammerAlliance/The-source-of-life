using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class Sqrt:ISpecialOperation
    {
        public double GeResult(double number)
        {
            double result = 0;
            result = Math.Sqrt(number);
            return result;
        }

        public string GetString(double number)
        {
            return "√(" + number + ")";
        }
    }
}
