
using System;
using System.Windows.Forms;


namespace Calculator.LZX.View
{
    public partial class Form1 : Form
    {    
        public static bool FirstInput = true;//是否第一次输入
        public static string lastVal = "";       //双目运算保存前一个数 
        public static bool isCanCalc = false;  //判断在按下双目运算符后 是进行计算 还是修改已有的Symbol   
        public static bool isClr = false;  //是否在OneText.Text有数字的情况下,重新输入
        private string symbol = "";//保存运算符

        public Form1()
        {
            InitializeComponent();
        }
        //数字按钮
        public void GetNum(object sender, EventArgs e)
        {
            string num = (sender as Button).Text;
            string str = OneText.Text;
            //OneText.Text= GetNumber.GetButtonText(num,str);
           

            
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
           
        }
        //等于
        private void Res_Btn_Click(object sender, EventArgs e)
        {
                
        }
        //C  初始化
        private void C_Btn_Click(object sender, EventArgs e)
        {          
            Form1_Load(sender, e);
            OneText.Text = "0";
            TwoBox.Text = "";
            FirstInput = true;
            lastVal = "";
            isCanCalc = false;
            isClr = false;
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
                                    
        }
    }
}
