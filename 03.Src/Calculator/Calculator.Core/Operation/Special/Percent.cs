using System;
using Calculator.Core.SDK;

namespace Calculator.Core.Opt
{
    /// <summary>
    /// todo: mh
    /// </summary>
    public class Percent : ISpecialOperation
    {
        public double GetResult(double number)
        {
            return 0;
        }

        public double GetResult(double left, double number)
        {
            return (left*number) / 100;
        }

        public string GetToString(string num)
        {
            return "";
        }
    }
}
