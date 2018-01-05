using System;
using System.Windows.Forms;
using Calculator.Core;


namespace Calculator.LZX.View
{
    public partial class Form1 : Form
    {    
        public static bool first = true;//是否第一次输入
        public static string lastVal = "";        
        public static bool CC = false;     
        public static bool CL = false;
        private string symbol = "";

        public Form1()
        {
            InitializeComponent();
        }
        //数字按钮
        public void GetNum(object sender, EventArgs e)
        {
            string num = (sender as Button).Text;
            string str = OneText.Text;
            OneText.Text= GetNumber.GetButtonText(num,str);
        }
        //初始化
        private void Form1_Load(object sender, EventArgs e)
        {
            TwoBox.Enabled = false;     
            OneText.Enabled = false;      
            OneText.Text = "";            
            OneText.Text = "0";           
        }
        //取反 
        private void Opp_Btn_Click(object sender, EventArgs e)
        {
            string str = OneText.Text;               
            double val = double.Parse(str);         
            val = -val;                            
            OneText.Text = val.ToString();           
        }
        //消除
        private void Back_Btn_Click(object sender, EventArgs e)
        {
            OneText.Text=Clean.Backspace(OneText.Text);
        }
        //运算符  +-*/
        private void Symbol_Btn_Click(object sender, EventArgs e)
        {
            string NowSymbol = (sender as Button).Text;
            object result;
            //如是第一次输入
            if (first == true)
            {
                lastVal = OneText.Text;   //将当前的值赋给 lastVal
                symbol = NowSymbol;     //将取得计算符合传进symbol
                OneText.Text = "0";       //刷新输入 为输入下一个数做准备
                first = false;   //已经完成 第一次输入 
                TwoBox.Text = lastVal + symbol; //显示第一个数和运算符合
                CC = false;      //没有输入第二个数 不能进行计算
            }
            else if (CC == true)    //如果允许计算
            {
                Operation oper = new Operation(); 
                oper = OperationFactory.creatOperation(symbol);
                oper.NumberA = double.Parse(lastVal);
                oper.NumberB = double.Parse(OneText.Text);
                result = oper.GetResult(); //计算函数


                TwoBox.Text = TwoBox.Text + OneText.Text + NowSymbol;   
                lastVal = OneText.Text = result.ToString();             
                symbol = NowSymbol;                                 //更新 新的待执行的双目运算的符合
                CL = true;                                       
                CC = false;                                  //没有输入输入下一个数,再次按下双目运算按钮,只能修改当前symbol的值
            }
            else
            {
                symbol = NowSymbol;     //不允许计算, 只能修改当前symbol的值
                OneText.Text = OneText.Text.Substring(0, OneText.Text.Length - 1) + symbol; 
            }
        }
        //等于
        private void Res_Btn_Click(object sender, EventArgs e)
        {
            
                //string str = (sender as Button).Text;
                Operation oper = new Operation();
                oper = OperationFactory.creatOperation(symbol);
                oper.NumberA = double.Parse(lastVal);
                oper.NumberB = double.Parse(OneText.Text);
                object result = oper.GetResult();
                TwoBox.Text = "";
                if (first == false)
                    OneText.Text = result.ToString();
                first = true;
                CL = true;
            
            
        }
        //C  初始化
        private void C_Btn_Click(object sender, EventArgs e)
        {          
            Form1_Load(sender, e);
            OneText.Text = "0";
            TwoBox.Text = "";
            first = true;
            lastVal = "";
            CC = false;
            CL = false;
        }
        //CE
        private void CE(object sender, EventArgs e)
        {
            OneText.Text = "0";
        }
        //小数点
        private void Point_Click(object sender, EventArgs e)
        {
            string str = (sender as Button).Text;   
            if (OneText.Text.IndexOf(str) == -1)     
            {                                                                             
                OneText.Text += str;
            }
        }
        /// <summary>
        /// 开方、平方、倒数的运算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sp_Click(object sender, EventArgs e)
        {
                string str = (sender as Button).Text;
                Special_Operation spo = new Special_Operation();
                spo = SpecalFactory.creatSpecial_Operation(str);
                spo.NumberA = double.Parse(OneText.Text);
                OneText.Text = spo.GetResult().ToString();
                TwoBox.Text = spo.GetString();                         
        }
    }
}

namespace Calculator.View
{
    class Special_Operation
    {
    }
}