using Calculator.Core;
using Calculator.Core.SDK;
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
        Calc cal = new Calc();

        public MainWindow()
        {
            InitializeComponent();
            Result_Text.Text = "0";
        }


        private void Num_Click(object sender, RoutedEventArgs e)
        {
            string input = ((Button)sender).Content.ToString();
            cal.InputNumber(Convert.ToInt32(input));
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
          

            string input = ((Button)sender).Content.ToString();
            switch (input)
            {
                case ".":
                    cal.InputSymbol(SymbolEnum.Point);
                    break;
                case "±":
                    cal.InputSymbol(SymbolEnum.Sign);
                    break;
                case "+":
                    cal.InputArithmetic(ArithmeticEnum.Add);
                    break;
                case "-":
                    cal.InputArithmetic(ArithmeticEnum.Sub);
                    break;
                case "*":
                    cal.InputArithmetic(ArithmeticEnum.Mul);
                    break;
                case "×":
                    cal.InputArithmetic(ArithmeticEnum.Mul);
                    break;
                case "/":
                    cal.InputArithmetic(ArithmeticEnum.Div);
                    break;
                //case "%":
                //    _Calculator.SpecOperation(SpecialEnum.Percent);
                //    break;
                //case "1/x":
                //    _Calculator.SpecOperation(SpecialEnum.Reciprocal);
                //    break;
                //case "√":
                //    _Calculator.SpecOperation(SpecialEnum.Sqrt);
                //    break;
                //case "MC":
                //    _Calculator.MOperation(MEnum.MClear);
                //    break;
                //case "MS":
                //    _Calculator.MOperation(MEnum.MSave);
                //    break;
                //case "MR":
                //    _Calculator.MOperation(MEnum.MRead);
                //    break;
                //case "M+":
                //    _Calculator.MOperation(MEnum.MAdd);
                //    break;
                //case "M-":
                //    _Calculator.MOperation(MEnum.MSub);
                //    break;
                case "←":
                    
                    break;
                case "CE":

                    break;
                case "C":

                    break;
                case "=":
                    cal.InputEqual();
                    break;
                default:
                    throw new Exception("操作符不存在");
            }
            ScreenDisplay();
        }

        public void ScreenDisplay()
        {
            Formula_Text.Text = _Calculator.Formulas.ToString();
            Result_Text.Text = _Calculator.Result;
        }

    }
}
