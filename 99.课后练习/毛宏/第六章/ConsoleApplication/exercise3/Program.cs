using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//创建一个委托，在请求用户输入时，使用它模拟 Console.ReadLine()函数。
namespace exercise3
{
    class Program
    {
        delegate string ReadLineDelegate();
        static void Main(string[] args)
        {
            ReadLineDelegate readLine = new ReadLineDelegate(Console.ReadLine);
            Console.WriteLine("Type a string:");
            string userInput = readLine();
            Console.WriteLine("You typed: {0}", userInput);
        }
    }
}
