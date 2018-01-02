using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 编写一个应用程序，该程序使用两个命令行参数，分别把值放在一个字符串和一个整型变
量中，然后显示这些值。
*/
namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Two arguments required.");
                return;
            }
            string param1 = args[0];
            int param2 = Convert.ToInt32(args[1]);
            Console.WriteLine("String parameter: {0}", param1);
            Console.WriteLine("Integer parameter: {0}", param2);
        }
    }
}
