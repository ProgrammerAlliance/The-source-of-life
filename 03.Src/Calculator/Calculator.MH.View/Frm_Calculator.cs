
using Calculator.Core;
using System;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Frm_Calculator : Form
    {
        ScreenData screenData = new ScreenData();

        //Operation oper = new Operation();
        //Special_Operation speOper = new Special_Operation();






        private string _symbol = null;
        private bool _lastIsSymbol = false;
        private bool _lastIsSpecial = false;
        private string result = "0";


        public Frm_Calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            labOfLine.SendToBack();
            //ScreenDisplay();
        }

        /// <summary>
        /// 数字按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_num_Click(object sender, EventArgs e)
        {
            string strBtn = ((Button)sender).Text;
            screenData.ProcessNum(strBtn, _lastIsSymbol);
            ScreenDisplay();
            _lastIsSymbol = false;
        }



        

        /// <summary>
        /// 加、减、乘、除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Syb_Click(object sender, EventArgs e)
        {
            //string strBtn = ((Button)sender).Text;

            ////获取加减乘除方法，为null则为第一次计算
            ////_symbol初始为null，为第一次计算
            //oper = OperationFactory.creatOperation(_symbol);

            //if (oper == null)//oper为空为第一次计算
            //{
            //    result = screenData.Lab_Answer;
            //    //oper.NumberB = Convert.ToDouble(result);
            //}
            //else
            //{
            //    oper.NumberA = Convert.ToDouble(result);
            //    oper.NumberB = Convert.ToDouble(screenData.Lab_Answer);
            //    result = oper.GetResult().ToString();
            //}
            //_symbol = strBtn;//该符号用作下次计算

            //screenData.ProcessSymbol(strBtn);

            //screenData.Lab_Answer = result;
            //ScreenDisplay();
            //_lastIsSymbol = true;
        }


        /// <summary>
        /// 根号，百分号，倒数特殊算法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Special_Click(object sender, EventArgs e)
        {
        //    string strBtn = ((Button)sender).Text;
        //    if (!_lastIsSpecial)
        //    {
        //        speOper = new Special_Operation();
        //        speOper = SpecalFactory.creatSpecial_Operation(strBtn);
        //        speOper.NumberA = Convert.ToDouble(screenData.Lab_Answer);
        //        speOper.StrFormula = speOper.NumberA.ToString();
        //    }

        //    speOper.GetResult();

        //    screenData.Lab_Answer = speOper.NumberA.ToString();

        //    ScreenDisplay();
        //    _lastIsSpecial = true;

        }



        /// <summary>
        /// 清空键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            //screenData = new ScreenData();
            //ScreenDisplay();
        }
        /// <summary>
        /// 清空输入框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CE_Click(object sender, EventArgs e)
        {
            //screenData.Lab_Answer = "0";
            //ScreenDisplay();
        }

        /// <summary>
        /// 删除键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_del_Click(object sender, EventArgs e)
        {
            //screenData.DelNumber();
            //ScreenDisplay();
        }

        private void btn_negate_Click(object sender, EventArgs e)
        {
        //    screenData.Lab_Answer = (-(Convert.ToDouble(lab_answer.Text))).ToString();
        //    ScreenDisplay();
        }











        #region 自定义方法




        public void ScreenDisplay()
        {
            lab_formula.Text = screenData.Lab_Formula;
            lab_answer.Text = screenData.Lab_Answer;
            lab_register.Text = screenData.Lab_Register;
        }



        #endregion


    }
}