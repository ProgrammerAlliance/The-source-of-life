using System;

namespace Calculator.Core
{
    public class Sqrt:Special_Operation
    {
        public override object GetResult()
        {
            double result = 0;
            result = Math.Sqrt(NumberA);
            return result;
        }

        public override string GetString()
        {
            return "√("+NumberA+")";
        }
    }
}
