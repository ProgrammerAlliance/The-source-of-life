using Calculator.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculator.WPF.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Core.Calculator _Calculator = new Core.Calculator();

        public MainWindow()
        {
            InitializeComponent();
            Result_Text.Text = "0";
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            string input = ((Button)sender).Content.ToString();
            switch (input)
            {
                case "+":
                    _Calculator.CalcOperation(OperateEnum.Add);
                    break;
                case "-":
                    _Calculator.CalcOperation(OperateEnum.Sub);
                    break;
                case "*":
                    _Calculator.CalcOperation(OperateEnum.Mul);
                    break;
                case "×":
                    _Calculator.CalcOperation(OperateEnum.Mul);
                    break;
                case "/":
                    _Calculator.CalcOperation(OperateEnum.Div);
                    break;
                case "%":
                    _Calculator.SpecOperation(SpecialEnum.Percent);
                    break;
                case "1/x":
                    _Calculator.SpecOperation(SpecialEnum.Reciprocal);
                    break;
                case "√":
                    _Calculator.SpecOperation(SpecialEnum.Sqrt);
                    break;
                case "MC":
                    _Calculator.MOperation(MEnum.MClear);
                    break;
                case "MS":
                    _Calculator.MOperation(MEnum.MSave);
                    break;
                case "MR":
                    _Calculator.MOperation(MEnum.MRead);
                    break;
                case "M+":
                    _Calculator.MOperation(MEnum.MAdd);
                    break;
                case "M-":
                    _Calculator.MOperation(MEnum.MSub);
                    break;
                case "←":
                    _Calculator.ClearOperation(ClearEnum.Del);
                    break;
                case "CE":
                    _Calculator.ClearOperation(ClearEnum.CE);
                    break;
                case "C":
                    _Calculator.ClearOperation(ClearEnum.C);
                    break;
                case "=":
                    _Calculator.CalcOperation(OperateEnum.Equal);
                    break;
                default:
                    throw new Exception("操作符不存在");
            }
            ScreenDisplay();
        }

        public void ScreenDisplay()
        {
            Formula_Text.Text = _Calculator.Formula;
            Result_Text.Text = _Calculator.Result;
        }

        private void Num_Click(object sender, RoutedEventArgs e)
        {
            string input = ((Button)sender).Content.ToString();
            _Calculator.CalcNumber(input);
        }
    }
}
