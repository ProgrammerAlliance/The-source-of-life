namespace Calculator.Core.Operation.Special
{
    public class Invert : ISpecialOperation
    {
        public double GetResult(double right)
        {
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
