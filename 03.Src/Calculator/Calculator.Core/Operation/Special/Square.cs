namespace Calculator.Core
{
    public class Square:ISpecialOperation
    {
        public double GetResult(double number)
        {
            double result = 0;
            result = number * number;
            return result;
        }

        public string GetToString(string num)
        {
            return $"sqr({num})";

        }
    }
}
