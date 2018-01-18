using System;

namespace Calculator.Core
{
    /// <summary>
    /// 开根号
    /// </summary>
    public class Sqrt : ISpecialOperation
    {
        public double GetResult(double right)
        {

            double result = 0;
            if (right < 0)
            {
                throw new CalcException("无效输入");
            }
            else
            {
                result = Math.Sqrt(right);
                return result;
            }
           
        }

        public string GetToString(string num)
        {
            return $"sqrt({num})";
        }
    }
}
