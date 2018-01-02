using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class exercise5
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber, fourthNumber;
            Console.WriteLine("Give me a number:");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me another number:");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me another number:");
            thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me another number:");
            fourthNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The product of {0}, {1}, {2}, and {3} is {4}.",
            firstNumber, secondNumber, thirdNumber, fourthNumber,
            firstNumber * secondNumber * thirdNumber * fourthNumber);
        }
    }
}
