using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变量的作用域
{
    class Program
    {
        static void Write()
        {
            Console.WriteLine("myString = {0}", myString);
            // myString 超出了作用域——它只能在 Main()中使用
        }
        static void Main(string[] args)
        {
            string myString = "String defined in Main()";
            Write();
            Console.ReadKey();
        }
    }
}
