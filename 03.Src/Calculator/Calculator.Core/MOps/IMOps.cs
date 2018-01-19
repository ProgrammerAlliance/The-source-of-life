using Calculator.Core.Save;
using Calculator.Core.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.MOps
{
    /// <summary>
    /// M键操作接口
    /// </summary>
    interface IMOps
    {
        Expression Process(Expression exp, Memory me);
    }
}
