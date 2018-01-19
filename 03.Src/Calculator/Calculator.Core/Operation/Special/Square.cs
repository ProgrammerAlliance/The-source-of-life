namespace Calculator.Core.Operation.Special
{
    /// <summary>
    /// 平方
    /// </summary>
    public class Square:ISpecialOperation
    {
        public double GetResult(double right)
        {
            double result = 0;
            result = right * right;
            return result;
        }

        public string GetToString(string num)
        {
            return $"sqr({num})";
        }
    }
}
