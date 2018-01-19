using Calculator.Core.Operation.Enum;

namespace Calculator.Core.Operation.Base
{
    /// <summary>
    /// 减法类
    /// </summary>
    public class OperationSub : IOperation
    {
        /// <summary>
        /// 减法计算
        /// </summary>
        /// <param name="left">左值</param>
        /// <param name="right">右值</param>
        /// <returns></returns>
        public double GetResult(double left, double right)
        {
            double result = 0;
            result = left - right;
            return result;
        }

        /// <summary>
        /// 减法算式
        /// </summary>
        /// <param name="num">左式</param>
        /// <returns></returns>
        public string GetToString(string num)
        {
            return num + (char)ArithmeticEnum.Sub;
        }
    }
}
