using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class Point
    {
        /// <summary>
        /// 输入小数点
        /// </summary>
        /// <param name="str"></param>
        /// <param name="lastIsSyb"></param>
        public void InputPoint(string str, bool lastIsSyb)
        {
            if (HasPoint(Lab_Answer)) { return; }
            if (lastIsSyb)
            {
                Lab_Answer = "0.";
            }
            if (IsLimitNum())
            {
                Lab_Answer += str;
            }
        }

    }
}
