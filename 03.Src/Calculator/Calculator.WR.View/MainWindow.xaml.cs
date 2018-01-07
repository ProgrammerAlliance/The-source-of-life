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
        public MainWindow()
        {
            InitializeComponent();
            resultShow.Text = "0";
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            string input = ((Button)sender).Content.ToString();
            
        }
    }
}
