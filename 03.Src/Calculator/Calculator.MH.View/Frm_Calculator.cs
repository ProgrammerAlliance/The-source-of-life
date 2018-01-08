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
        }

        private void Btn_Number_Click(object sender, EventArgs e)
        {
            string strBtn = ((Button)sender).Text;
            calculator.CalcNumber(strBtn);
            ScreenDisplay();
        }


        /// <summary>
        /// 数字按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Calculator_Click(object sender, EventArgs e)
        {
            string strBtn = ((Button)sender).Text;
            switch (strBtn)
            {
                case "+":
                    calculator.CalcOperation(Core.OperateEnum.Add, strBtn);
                    break;
                case "-":
                    calculator.CalcOperation(Core.OperateEnum.Sub, strBtn);
                    break;
                case "*":
                    calculator.CalcOperation(Core.OperateEnum.Mul, strBtn);
                    break;
                case "/":
                    calculator.CalcOperation(Core.OperateEnum.Div, strBtn);
                    break;
                case "±":


                    break;
                case "%":
                    calculator.SpecOperation(Core.SpecialEnum.Percent, strBtn);
                    break;
                case "1/x":
                    calculator.SpecOperation(Core.SpecialEnum.Reciprocal, strBtn);
                    break;
                case "√":
                    calculator.SpecOperation(Core.SpecialEnum.Sqrt, strBtn);
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
                    calculator.Equal();
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
            Lab_Formula.Text = calculator.GetFormula();
            Lab_Result.Text = calculator.GetAnswer();
            Lab_Register.Text = calculator.GetRegister();
        }
    }
}