namespace Calculator.Core.Opt
{/// <summary>
 /// 百分号
 /// </summary>
    public class Percent : ISpecialOperation
    {
        public double GetResult(double number)
        {
            double result = 0;
            result = number / 100;
            return result;
        }

        public string GetString(double number)
        {
            throw new System.NotImplementedException();
        }
    }
}
