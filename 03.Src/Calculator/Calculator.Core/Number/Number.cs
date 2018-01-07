using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class Number
    {
        StringBuilder stringBuilder = new StringBuilder();

        /// <summary>
        /// 输入数字
        /// </summary>
        /// <param name="str">输入的字符</param>
        /// <param name="isFirstNumberInput">是否是第一次输入</param>
        /// <returns></returns>
        public double GetNumber(string str, ref bool isFirstNumberInput)
        {
            if (isFirstNumberInput)
            {
                if ("0".Equals(str))
                {
                    return 0;
                }
                else
                {
                    stringBuilder.Append(str);
                    isFirstNumberInput = false;
                    return Convert.ToDouble(str);
                }
            }
            else
            {
                if (IsLimitNum())
                {
                    stringBuilder.Append(str);
                }
                return Convert.ToDouble(stringBuilder.ToString());
            }
        }

        /// <summary>
        /// 输入小数点
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string Point(string str)
        {
            if (HasPoint(stringBuilder.ToString()))
            {
                stringBuilder.Append(str);
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// 判断位数是否超过限制
        /// </summary>
        /// <returns></returns>
        public bool IsLimitNum()
        {
            if (HasPoint(stringBuilder.ToString()))
            {
                string[] temp = stringBuilder.ToString().Split('.');
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
                if (stringBuilder.ToString().Length > 16)
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
        /// <returns></returns>
        public bool HasPoint(string str)
        {
            str = stringBuilder.ToString();
            if (str.IndexOf(".") != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 取反
        /// </summary>
        /// <param name="number">需要取反的数</param>
        /// <returns></returns>
        public double Invert(double number)
        {
            return -number;
        }
    }
}
