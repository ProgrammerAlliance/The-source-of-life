using Calculator.Core.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Ops
{
    /// <summary>
    /// 按键操作接口
    /// </summary>
    public interface IOps
    {
        /// <summary>
        /// 定义按键的抽象方法
        /// </summary>
        /// <param name="exp">要进行操作的表达式</param>
        /// <returns></returns>
        Expression Process(Expression exp);
    }
}
