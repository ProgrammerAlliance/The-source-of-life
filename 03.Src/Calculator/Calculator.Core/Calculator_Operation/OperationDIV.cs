namespace Calculator.Core
{
    public class OperationDIV : IOperation
    {
<<<<<<< HEAD
        public override double GetResult()
=======
        public double GetResult(double number1, double number2)
>>>>>>> c91dbec4ac1806d5b5a6795e8a72deb349337b7c
        {
            double result = 0;

            if (number1 == 0 && number2 == 0)
            {
<<<<<<< HEAD
                throw new Exception("结果未定义");
=======
                throw new Exception("结果未定义!");
>>>>>>> c91dbec4ac1806d5b5a6795e8a72deb349337b7c
            }
            else if (number2 != 0)
            {
                result = number1 / number2;
            }
            else
            {
<<<<<<< HEAD
                throw new Exception("除数不能为零");
=======
                throw new Exception("除数不能为零!");
>>>>>>> c91dbec4ac1806d5b5a6795e8a72deb349337b7c
            }
            return result;
        }
    }
}
