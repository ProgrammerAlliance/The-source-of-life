using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class Number
    {
        Limit limit = new Limit();
        /// <summary>
        /// 处理显示的数字
        /// </summary>
        /// <param name="num">当前点击的数字</param>
        /// <param name="lastIsSyb">判断上一次输入的是否是符号</param>
        public string ProcessNum(string num, bool lastIsSyb,string input)
        {
            if(!limit.IsLimited(input)) { return input; }
            if(lastIsSyb||"0".Equals(input))
            {
                input = "";
            }
            input += num;
            return input;
        }

        /// <summary>
        /// 取反
        /// </summary>
        /// <returns></returns>
        public void Invert(string input)
        {
            input =( -(Convert.ToDouble(input))).ToString();
        }



    }
}
