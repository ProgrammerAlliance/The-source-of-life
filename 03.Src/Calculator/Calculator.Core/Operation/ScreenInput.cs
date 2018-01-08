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
            bool doIt = false;

            bool doDot = false;//是否要写小数点
            if (".".Equals(num) && !HasPoint())//在输入为小数点时判断是否有小数点
            {
                doDot = true;
            }
            if (!IsLimitNum(doDot)) { return; }//数字长度超出限制

            if(doDot)
            {
                if ("0".Equals(_lab_Answer)) { _lab_Answer = "0."; }
                else { _lab_Answer += num; }
            }
            else if(!".".Equals(num))
            {
                if (lastIsSyb|| "0".Equals(_lab_Answer)) { _lab_Answer = ""; }
                else { _lab_Answer += num; }
            }
        }

        /// <summary>
        /// 处理显示的符号
        /// </summary>
        /// <param name="syb"></param>
        public void ProcessSymbol(string syb)
        {
            _lab_Formula += _lab_Answer + syb;
        }

        /// <summary>
        /// 判断位数是否超过限制
        /// </summary>
        /// <returns></returns>
        public bool IsLimitNum(bool doDot)
        {
            if (_lab_Answer.Length < 16) { return true; }
            if (_lab_Answer.Length == 16 && doDot) { return true; }
            return false;
        }

        /// <summary>
        /// 判断是否存在小数点
        /// </summary>
        /// <returns></returns>
        public bool HasPoint()
        {

            if (_lab_Answer.IndexOf(".") != -1)
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

        public void CE()
        {
            //单目运算还需删除上一行算式

            Lab_Answer = "0";
        }
        public void C()
        {
            Lab_Answer = "0";
            Lab_Formula = "";
        }

    }
}
