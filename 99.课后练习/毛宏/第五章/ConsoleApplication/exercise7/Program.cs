using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//编写一个控制台应用程序，给字符串中的每个单词加上双引号。
namespace exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string myString = Console.ReadLine();
            string[] myWords = myString.Split(' ');
            Console.WriteLine("Adding double quotes around words:");
            foreach (string myWord in myWords)
            {
                Console.Write("\"{0}\" ", myWord);
            }
        }
    }
}
