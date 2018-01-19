using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    /// <summary>
    /// 二目运算和算式
    /// </summary>
    public interface IOperation
    {
        /// <summary>
        /// 运算的抽象方法
        /// </summary>
        /// <param name="left">左值</param>
        /// <param name="right">右值</param>
        /// <returns></returns>
        double GetResult(double left, double right);

        /// <summary>
        /// 获得算式的抽象方法
        /// </summary>
        /// <param name="num">左式</param>
        /// <returns></returns>
        string GetToString(string num);
        
    }
}
