using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Number
{
    class Number
    {
        bool isFirstNumberInput = true;

        StringBuilder stringBuilder = new StringBuilder();

        /// <summary>
        /// 输入数字
        /// </summary>
        /// <param name="str">按钮上的字符</param>
        /// <returns></returns>
        public double GetNumber(string str)
        {
            if (isFirstNumberInput)
            {
                if ("0".Equals(str))
                {
                    return 0;
                }
                else
                {
                    isFirstNumberInput = false;
                    stringBuilder.Append(str);
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

        public string Point(string str)
        {
            if (HasPoint())
            {
                stringBuilder.Append(str);
            }
            return str;
        }

        /// <summary>
        /// 判断位数是否超过限制
        /// </summary>
        /// <returns></returns>
        private bool IsLimitNum()
        {
            if (HasPoint())
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
        private bool HasPoint()
        {
            if (stringBuilder.ToString().IndexOf(".") != -1)
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

