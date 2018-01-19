using Calculator.Core.Enum;
using Calculator.Core.Opt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    /// <summary>
    /// 除法类
    /// </summary>
    public class OperationDiv : IOperation
    {
        /// <summary>
        /// 除法计算
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public double GetResult(double left, double right)
        {
            double result = 0;

            if (left == 0 && right == 0)
            {
                throw new CalcException("结果未定义");
            }
            else if (right != 0)
            {
                result = left / right;
            }
            else
            {
                throw new CalcException("除数不能为零");
            }
            return result;
        }

        /// <summary>
        /// 除法算式
        /// </summary>
        /// <param name="num">左式</param>
        /// <returns></returns>
        public string GetToString(string num)
        {
            return num + (char)ArithmeticEnum.Div;
        }
    }
}
