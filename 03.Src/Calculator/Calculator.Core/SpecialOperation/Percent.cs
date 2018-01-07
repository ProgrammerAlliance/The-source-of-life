namespace Calculator.Core
{/// <summary>
 /// 百分号
 /// </summary>
    public class Percent : ISpecialOperation
    {
<<<<<<< HEAD
        public override double GetResult()
=======
        public double GeResult(double number)
>>>>>>> c91dbec4ac1806d5b5a6795e8a72deb349337b7c
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
