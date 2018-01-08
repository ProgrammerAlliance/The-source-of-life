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
        public bool IsLimited()
        {
            if (HasPoint(Lab_Answer.ToString()))
            {
                string[] temp = Lab_Answer.ToString().Split('.');
                string num_length = temp[0] + temp[1];
                if (num_length.Length > 16)
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
                if (Lab_Answer.ToString().Length > 16)
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
