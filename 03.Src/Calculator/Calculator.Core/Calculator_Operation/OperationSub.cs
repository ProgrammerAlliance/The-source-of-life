namespace Calculator.Core
{
    public class OperationSub : IOperation
    {
        public double GetResult(double number1, double number2)
        {
            double result = 0;
            result = number1 - number2;
            return result;
        }
    }
}
