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


        /// <summary>
        /// 数字按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Calculator_Click(object sender, EventArgs e)
        {
            string strBtn = ((Button)sender).Text;
            calculator.CalcOperation(strBtn);
            ScreenDisplay();
            //_lastIsSymbol = false;
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