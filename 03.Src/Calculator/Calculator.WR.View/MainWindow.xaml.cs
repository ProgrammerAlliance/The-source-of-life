using System.Windows;
using System.Windows.Controls;
using Calculator.Core.Number;
using Calculator.Core;
using System;

namespace Calculator.WPF.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Number num = new Number();

        public double Current_number = 0;

        /// <summary>
        /// 存放符号
        /// </summary>
        public string temp;

        public MainWindow()
        {
            InitializeComponent();
            resultShow.Text = Current_number.ToString();
        }

        private void Num_Click(object sender, RoutedEventArgs e)
        {
            string input = ((Button)sender).Content.ToString();
            Current_number = num.GetNumber(input);
            resultShow.Text = Convert.ToString(Current_number);
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            string input = ((Button)sender).Content.ToString();
            num.Point(input);
        }

        private void Opt_Click(object sender, RoutedEventArgs e)
        {
            string input = ((Button)sender).Content.ToString();
            Operation op = new Operation();
            op = OperationFactory.creatOperation(temp);
            op._numberA = Current_number;
        }

        private void InvertSign_Click(object sender, RoutedEventArgs e)
        {
            num.Invert(Current_number);
        }
    }
}
