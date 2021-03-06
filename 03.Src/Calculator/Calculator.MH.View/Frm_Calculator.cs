﻿using Calculator.Core.Operation.Enum;
using Calculator.Core.SDK;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Calculator.MH.View
{

    public partial class Frm_Calculator : Form
    {
        Calc calc = new Calc();

        public Frm_Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            labOfLine.SendToBack();
            Lab_Result.Focus();
        }

        /// <summary>
        /// 数字按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Number_Click(object sender, EventArgs e)
        {
            calc.InputNumber(Convert.ToInt32(((Button)sender).Text));
            ScreenDisplay();
        }

        /// <summary>
        /// 符号按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Calculator_Click(object sender, EventArgs e)
        {
            string strBtn = ((Button)sender).Text;
            switch (strBtn)
            {
                case ".":
                    calc.InputSymbol(SymbolEnum.Point);
                    break;
                case "±":
                    calc.InputSymbol(SymbolEnum.Sign);
                    break;
                case "+":
                    calc.InputArithmetic(ArithmeticEnum.Add);
                    break;
                case "-":
                    calc.InputArithmetic(ArithmeticEnum.Sub);
                    break;
                case "*":
                    calc.InputArithmetic(ArithmeticEnum.Mul);
                    break;
                case "/":
                    calc.InputArithmetic(ArithmeticEnum.Div);
                    break;
                case "%":
                    calc.InputOneOperation(SpecialEnum.Percent);
                    break;
                case "1/x":
                    calc.InputOneOperation(SpecialEnum.Reciprocal);
                    break;
                case "√":
                    calc.InputOneOperation(SpecialEnum.Sqrt);
                    break;
                case "MC":
                    calc.InputMemory(MEnum.MClear);
                    break;
                case "MS":
                    calc.InputMemory(MEnum.MSave);
                    break;
                case "MR":
                    calc.InputMemory(MEnum.MRead);
                    break;
                case "M+":
                    calc.InputMemory(MEnum.MAdd);
                    break;
                case "M-":
                    calc.InputMemory(MEnum.MSub);
                    break;
                case "←":
                    calc.InputClear(ClearEnum.Del);
                    break;
                case "CE":
                    calc.InputClear(ClearEnum.CE);
                    break;
                case "C":
                    calc.InputClear(ClearEnum.C);
                    break;
                case "=":
                    calc.InputEqual();
                    break;
                default:
                    throw new Exception("操作符不存在");
            }
            ScreenDisplay();
        }

        /// <summary>
        /// 向屏幕显示输出
        /// </summary>
        public void ScreenDisplay()
        {
            try
            {
                //显示结果  调整字号
                string str = calc.R();
                if (str.Length < 14)
                {
                    Lab_Result.Font = new System.Drawing.Font("宋体", 14F);
                }
                else if (str.Length < 17)
                {
                    Lab_Result.Font = new System.Drawing.Font("宋体", 12F);
                }
                else
                {
                    Lab_Result.Font = new System.Drawing.Font("宋体", 10F);
                }
                //显示表达式
                Lab_Result.Text = str;
                string formula = calc.GetFormula();
                formula = ProcessFormula(formula);
                Lab_Formula.Text = formula;
                //显示Memery标记
                if (calc.M())
                {
                    Lab_Register.Text = "M";
                }
                else
                {
                    Lab_Register.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("系统异常，请重试！");
            }
        }

        /// <summary>
        /// 处理生成的字符串，过长要省略显示：<<1+2+3+
        /// </summary>
        public string ProcessFormula(string formula)
        {
            string result = "";
            string regex = "+-*/";
            foreach (char c in formula)
            {
                if (regex.Contains(c.ToString()))
                {
                    result += $" {c} ";
                }
                else
                    result += c;
            }
            if (result.Length > 28)
            {
                result = "<<" + result.Substring(result.Length - 28);
            }
            return result;
        }

        /// <summary>
        /// 鼠标移动到按钮改变颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(255, 232, 207);
        }

        /// <summary>
        /// 鼠标离开按钮改变颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Num_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(234, 241, 248);
        }

        /// <summary>
        /// 鼠标离开按钮改变颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Syb_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(212, 224, 237);
        }
    }
}