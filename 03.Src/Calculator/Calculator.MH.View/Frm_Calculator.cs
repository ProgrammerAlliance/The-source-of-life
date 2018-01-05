using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Core;


namespace Calculator
{

    public partial class Frm_Calculator : Form
    {
        ScreenData screenData = new ScreenData();
        Operation oper;

        public Frm_Calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
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
        private void btn_num_Click(object sender, EventArgs e)
        {
            string strBtn = ((Button)sender).Text;
            screenData.ProcessNum(strBtn);
            ScreenDisplay();
        }





        /// <summary>
        /// 加、减、乘、除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Syb_Click(object sender, EventArgs e)
        {
            string strBtn = ((Button)sender).Text;

            oper = OperationFactory.creatOperation(strBtn);
            oper.NumberB = Convert.ToDouble(screenData.Lab_Answer);
            screenData.ProcessSymbol(strBtn);

            //计算
            



            string result = oper.GetResult().ToString();

            //计算

            screenData.Lab_Answer = result;
            ScreenDisplay();
        }



        /// <summary>
        /// 清空键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            screenData = new ScreenData();
            ScreenDisplay();
        }
        /// <summary>
        /// 清空输入框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CE_Click(object sender, EventArgs e)
        {
            screenData.Lab_Answer = "0";
            ScreenDisplay();
        }

        /// <summary>
        /// 删除键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_del_Click(object sender, EventArgs e)
        {
            screenData.DelNumber();
            ScreenDisplay();
        }

        private void btn_negate_Click(object sender, EventArgs e)
        {
            screenData.Lab_Answer = (-(Convert.ToDouble(lab_answer.Text))).ToString();
            ScreenDisplay();
        }











        #region 自定义方法


        public void Count()
        {

        }


        public void ScreenDisplay()
        {
            lab_formula.Text = screenData.Lab_Formula;
            lab_answer.Text = screenData.Lab_Answer;
            lab_register.Text = screenData.Lab_Register;
        }


        #endregion


    }
}