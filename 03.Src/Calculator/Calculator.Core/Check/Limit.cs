using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class Limit
    {
        /// <summary>
        /// 判断位数是否超过限制
        /// </summary>
        /// <returns></returns>
        public bool IsLimited(string input)
        {
            if (input == null) return true;
            if (HasPoint(input.ToString()))
            {
                string[] temp = input.ToString().Split('.');
                string num_length = temp[0] + temp[1];
                if (num_length.Length > 15)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (input.ToString().Length > 15)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        /// <summary>
        /// 判断是否存在小数点
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool HasPoint(string str)
        {

            if (str.IndexOf(".") != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
