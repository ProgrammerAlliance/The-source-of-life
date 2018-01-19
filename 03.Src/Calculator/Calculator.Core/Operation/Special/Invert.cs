using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class Invert : ISpecialOperation
    {
        public double GetResult(double right)
        {
            // right = exp.R.StartsWith("-") ? exp.R.Remove(0, 1) : $"-{exp.R}";
            return 0;
        }
        public string GetResult(string str)
        {
            str = str.StartsWith("-") ? str.Remove(0, 1) : $"-{str}";
            return str;
        }
        public string GetToString(string num)
        {
            return $"negate({num})";
        }
    }
}
