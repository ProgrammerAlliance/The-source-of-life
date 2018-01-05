using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.LZX.View
{
    /// <summary>
    /// 退格
    /// </summary>
    class Clean

    {
        /// <summary>
        /// 退格键
        /// </summary>
        public static string  Backspace(string str)
        {
            if (str.Length == 1)
                str = "0";
            else
                str = str.Substring(0, str.Length - 1);
            return str;

        }
    }
}
