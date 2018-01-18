using Calculator.Core.SDK;
using System;
using System.Windows.Forms;


namespace Calculator
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


        private void Btn_Calculator_Click(object sender, EventArgs e)
        {
            string strBtn = ((Button)sender).Text;
            switch (strBtn)
            {
                case ".":
                    calc.InputSymbol(Core.SymbolEnum.Point);
                    break;
                case "±":
                    calc.InputSymbol(Core.SymbolEnum.Sign);
                    break;
                case "+":
                    calc.InputArithmetic(Core.ArithmeticEnum.Add);
                    break;
                case "-":
                    calc.InputArithmetic(Core.ArithmeticEnum.Sub);
                    break;
                case "*":
                    calc.InputArithmetic(Core.ArithmeticEnum.Mul);
                    break;
                case "/":
                    calc.InputArithmetic(Core.ArithmeticEnum.Div);
                    break;
                case "%":
                    calc.InputOneOperation(Core.SpecialEnum.Percent);
                    break;
                case "1/x":
                    calc.InputOneOperation(Core.SpecialEnum.Reciprocal);
                    break;
                case "√":
                    calc.InputOneOperation(Core.SpecialEnum.Sqrt);
                    break;
                case "MC":
                case "MS":
                case "MR":
                case "M+":
                case "M-":
                    calc.InputMemory(strBtn);
                    break;
                case "←":
                    calc.InputClear(Core.ClearEnum.Del);
                    break;
                case "CE":
                    calc.InputClear(Core.ClearEnum.CE);
                    break;
                case "C":
                    calc.InputClear(Core.ClearEnum.C);
                    break;
                case "=":
                    calc.InputEqual();
                    break;
                default:
                    throw new Exception("操作符不存在");
            }
            ScreenDisplay();
        }

        private void Btn_Memory_Click(object sender, EventArgs e)
        {
            string strBtn = ((Button)sender).Text;
            ScreenDisplay();

        }

        public void DisplaySome()
        {
            Lab_Result.Text = calc.R();
        }
        /// <summary>
        /// 向屏幕显示输出
        /// </summary>
        public void ScreenDisplay()
        {
            Lab_Result.Text = calc.R();
            Lab_Formula.Text = calc.GetFormula();
        }

    }
}