using Calculator.Core.Operation.Special;

namespace Calculator.Core.Opt.Operation.Special
{
    public class Percent : ISpecialOperation
    {
        /// <summary>
        /// 百分号计算
        /// </summary>
        public double GetResult(double right)
        {
            return 0;
        }

        /// <summary>
        /// 重载计算方法
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public double GetResult(double left, double right)
        {
            return (left* right) / 100;
        }

        /// <summary>
        /// 百分号算式
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string GetToString(string num)
        {
            return num;
        }
    }
}
