namespace Calculator.Core
{
    public class OperationMul : IOperation
    {
<<<<<<< HEAD
        public override double GetResult()
        {  
                double result = 0;
                result = NumberA * NumberB;
                return result;    
=======
        public double GetResult(double number1, double number2)
        {
            double result = 0;
            result = number1 * number2;
            return result;
>>>>>>> c91dbec4ac1806d5b5a6795e8a72deb349337b7c
        }
    }
}
