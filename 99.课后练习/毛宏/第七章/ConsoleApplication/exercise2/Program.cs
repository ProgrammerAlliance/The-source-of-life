using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 为一个简单的应用程序编写代码，其中包含一个循环，该循环在运行 5000 次后产生一个错
误。使用断点在第 5000 次循环出现错误前进入中断模式(注意产生错误的一种简单方式是试图访问
一个不存在的数组元素，例如在一个有 100 个元素的数组中，访问 myArray[1000])。
*/
namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10000; i++)
            {
                Console.WriteLine("Loop cycle {0}", i);
                if (i == 5000)
                {
                    Console.WriteLine(args[999]);
                }
            }
        }
    }
}
