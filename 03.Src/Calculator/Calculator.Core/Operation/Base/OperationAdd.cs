using Calculator.Core.Enum;

namespace Calculator.Core
{
    /// <summary>
    /// 加法计算
    /// </summary>
    public class OperationAdd : IOperation
    {
        public double GetResult(double left, double right)
        {
            double result = 0;
            result = left + right;
            return result;
        }
        /// <summary>
        /// 加法算式
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string GetToString(string num)
        {
            return num + (char)ArithmeticEnum.Add;
        }
    }
}
