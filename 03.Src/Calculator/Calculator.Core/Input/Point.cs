using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class Point
    {
        Limit limit = new Limit();
        /// <summary>
        /// 输入小数点
        /// </summary>
        /// <param name="str"></param>
        /// <param name="lastIsSyb"></param>
        public string InputPoint(string str, bool lastIsSyb,string input)
        {
            if (limit.HasPoint(input)) { return input; }
            if (lastIsSyb)
            {
                input = "0.";
            }
            if (limit.IsLimited(input))
            {
                input += str;
            }
            return input;
        }

    }
}
