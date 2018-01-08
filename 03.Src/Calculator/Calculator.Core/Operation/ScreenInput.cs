using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class ScreenInput
    {
        /// <summary>
        /// 算式框内容
        /// </summary>
        private string _lab_Formula = "";

        /// <summary>
        /// 输入框内容
        /// </summary>
        private string _lab_Answer = "0";

        /// <summary>
        /// 寄存器存储数据后显示“M”
        /// Win10不需要
        /// </summary>
        private string _lab_Register = "";

        public string Lab_Formula
        {
            get { return _lab_Formula; }
            set { _lab_Formula = value; }
        }
        public string Lab_Answer
        {
            get { return _lab_Answer; }
            set { _lab_Answer = value; }
        }
        public string Lab_Register
        {
            get { return _lab_Register; }
            set { _lab_Register = value; }
        }



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
        /// 输入小数点
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public void Point(string str,bool lastIsSyb)
        {
            if (HasPoint(Lab_Answer)) { return; }
            if (lastIsSyb)
            {
                Lab_Answer = "0.";
            }
            if(IsLimitNum())
            {
                Lab_Answer += str;
            }
        }


        /// <summary>
        /// 处理显示的符号
        /// </summary>
        /// <param name="syb"></param>
        public void ProcessSymbol(string syb,bool lastIsSymbol)
        {
            if(lastIsSymbol&&Lab_Formula.Length-1>0)
            {
                Lab_Formula = Lab_Formula.Remove(Lab_Formula.Length - 1)+syb;
                return;
            }
            double strLab= Convert.ToDouble(Lab_Answer);
            _lab_Formula += strLab.ToString() + syb;
        }

        /// <summary>
        /// 判断位数是否超过限制
        /// </summary>
        /// <returns></returns>
        public bool IsLimitNum()
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
