using System;
using System.Windows.Forms;


namespace Calculator
{

    public partial class Frm_Calculator : Form
    {
        Calculator.Core.Calculator calculator = new Core.Calculator();


        public Frm_Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            labOfLine.SendToBack();
            ScreenDisplay();
        }

        private void Btn_Number_Click(object sender, EventArgs e)
        {
            string strBtn = ((Button)sender).Text;
            calculator.CalcNumber(strBtn);
        }


        /// <summary>
        /// 数字按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Calculator_Click(object sender, EventArgs e)
        {
            string strBtn = ((Button)sender).Text;
            switch(strBtn)
            {
                case "+":
                    calculator.CalcOperation(Core.OperateEnum.Add);
                    break;
                case "-":
                    calculator.CalcOperation(Core.OperateEnum.Sub);
                    break;
                case "*":
                    calculator.CalcOperation(Core.OperateEnum.Mul);
                    break;
                case "/":
                    calculator.CalcOperation(Core.OperateEnum.Div);
                    break;
                case "%":
                    calculator.SpecOperation(Core.SpecialEnum.Percent);
                    break;
                case "1/x":
                    calculator.SpecOperation(Core.SpecialEnum.Reciprocal);
                    break;
                case "√":
                    calculator.SpecOperation(Core.SpecialEnum.Sqrt);
                    break;
                case "MC":
                    calculator.MOperation(Core.MEnum.MClear);
                    break;
                case "MS":
                    calculator.MOperation(Core.MEnum.MSave);
                    break;
                case "MR":
                    calculator.MOperation(Core.MEnum.MRead);
                    break;
                case "M+":
                    calculator.MOperation(Core.MEnum.MAdd);
                    break;
                case "M-":
                    calculator.MOperation(Core.MEnum.MSub);
                    break;
                case "←":
                    calculator.ClearOperation(Core.ClearEnum.Del);
                    break;
                case "CE":
                    calculator.ClearOperation(Core.ClearEnum.CE);
                    break;
                case "C":
                    calculator.ClearOperation(Core.ClearEnum.C);
                    break;
                case "=":
                    calculator.CalcOperation(Core.OperateEnum.Equal);
                    break;
                default:
                    throw new Exception("操作符不存在");
            }
            ScreenDisplay();
        }

        private void Btn_Memory_Click(object sender, EventArgs e)
        {
            string strBtn = ((Button)sender).Text;
            calculator.MemoryOperation(strBtn);
            ScreenDisplay();

        }

        /// <summary>
        /// 向屏幕显示输出
        /// </summary>
        public void ScreenDisplay()
        {
            Lab_Formula.Text = calculator.Formula;
            Lab_Result.Text = calculator.Result;
            Lab_Register.Text = calculator.Memorys?.Count > 0 ? "M" : "";
        }
    }
}