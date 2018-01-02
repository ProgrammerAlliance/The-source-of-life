using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  编写一个控制台应用程序，它接收用户输入的一个字符串，将其中的字符以与输入相反的顺序输出。
*/
namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string myString = Console.ReadLine();
            string reversedString = "";
            for (int index = myString.Length - 1; index >= 0; index--)
            {
                reversedString += myString[index];
            }
            Console.WriteLine("Reversed: {0}", reversedString);
        }
    }
}
