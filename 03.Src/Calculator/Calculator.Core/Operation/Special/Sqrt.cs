using System;

namespace Calculator.Core
{
    /// <summary>
    /// 开根号
    /// </summary>
    public class Sqrt : ISpecialOperation
    {
        /// <summary>
        /// 根号运算
        /// </summary>
        /// <param name="right"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 根号算式
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string GetToString(string num)
        {
            return $"sqrt({num})";
        }
    }
}
