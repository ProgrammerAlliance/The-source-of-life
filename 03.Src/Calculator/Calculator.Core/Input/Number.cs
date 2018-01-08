using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class Number
    {

        /// <summary>
        /// 处理显示的数字
        /// </summary>
        /// <param name="num">当前点击的数字</param>
        /// <param name="lastIsSyb">判断上一次输入的是否是符号</param>
        public void ProcessNum(string num, bool lastIsSyb)
        {
            if(!IsLimitNum()) { return; }
            if(lastIsSyb||"0".Equals(Lab_Answer))
            {
                Lab_Answer = "";
            }
            Lab_Answer += num;
        }

        /// <summary>
        /// 取反
        /// </summary>
        /// <returns></returns>
        public void Invert()
        {
            Lab_Answer =( -(Convert.ToDouble(Lab_Answer))).ToString();
        }



    }
}
