using Calculator.Core.Enum;

namespace Calculator.Core
{
    /// <summary>
    /// 减法计算
    /// </summary>
    public class OperationSub : IOperation
    {
        public double GetResult(double left, double right)
        {
            double result = 0;
            result = left - right;
            return result;
        }
        /// <summary>
        /// 减法算式
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string GetToString(string num)
        {
            return num + (char)ArithmeticEnum.Sub;
        }
    }
}
