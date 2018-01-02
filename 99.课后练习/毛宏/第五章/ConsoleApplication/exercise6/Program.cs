using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//编写一个控制台应用程序，它接收一个字符串，用 yes 替换字符串中所有的 no。
namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string myString = Console.ReadLine();
            myString = myString.Replace("no", "yes");
            Console.WriteLine("Replaced \"no\" with \"yes\": {0}", myString);
        }
    }
}
