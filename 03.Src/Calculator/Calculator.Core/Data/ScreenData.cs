using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class ScreenData
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
        /// 处理数字键
        /// </summary>
        /// <param name="num"></param>
        public void ProcessNum(string num,bool lastIsSyb)
        {

            if("0".Equals(_lab_Answer)||lastIsSyb)
            {
                _lab_Answer = "";
            }

            _lab_Answer += num;

        }

        /// <summary>
        /// 处理符号键
        /// </summary>
        /// <param name="syb"></param>
        public void ProcessSymbol(string syb)
        {
            _lab_Formula += _lab_Answer + syb;
        }


        /// <summary>
        /// 删除键功能，将输入框的数字删除一位
        /// </summary>
        public void DelNumber()
        {
            _lab_Answer = ((_lab_Answer.Length) == 1) ? "0" : _lab_Answer.Remove(_lab_Answer.Length - 1);
        }


        /// <summary>
        /// 向界面显示框写入数据
        /// </summary>
        public void Display()
        {
            //向窗体输出
        }
    }
}
