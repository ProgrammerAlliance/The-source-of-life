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
            double result = 0;
            result = number / 100;
            return result;
        }

        public string GetToString(Expression exp)
        {
            return exp.R;
        }

    }
}
