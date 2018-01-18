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
        double GetResult(double left, double right);
        string GetToString(string num);


    }
}
