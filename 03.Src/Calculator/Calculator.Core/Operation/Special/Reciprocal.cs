using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Core.SDK;
using Calculator.Core.Core;

namespace Calculator.Core.Operation.Special
{
    /// <summary>
    /// 倒数
    /// </summary>
    public class Reciprocal : ISpecialOperation
    {
        /// <summary>
        /// 重载的计算方法
        /// </summary>
        /// <param name="right"></param>
        /// <returns></returns>
        public double GetResult(double right)
        {
            double result = 0;
            if (right == 0)
            {
                throw new CalcException("除数不能为零");
            }
            else
            {
                result = 1 / right;
            }
            return result;
        }

        /// <summary>
        /// 倒数算式
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string GetToString(string num)
        {
            return $"reciproc({num})";

        }
    }
}