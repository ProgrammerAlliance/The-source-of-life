using System;
using System.Windows.Forms;

namespace Calculator.LZX.View
{
    class GetNumber
    {
        /// <summary>
        /// 获取数字按钮的值
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        
        public static string  GetButtonText(string num,string str)
        {
            if (Form1.CL == true)
            {
                 str= "0";
                Form1.CL = false;
            }

            if (str == "0")

                str = num;
            else
                str += num;

            if (Form1.first == false)
                Form1.CC = true;

            return str;

        }


    }
}
