namespace Calculator.Core
{
<<<<<<< HEAD
    public  class OperationAdd:Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
=======
    public class OperationAdd : IOperation
    {
        public double GetResult(double number1, double number2)
        {
            double result = 0;
            result = number1 + number2;
>>>>>>> c91dbec4ac1806d5b5a6795e8a72deb349337b7c
            return result;
        }
    }
}
