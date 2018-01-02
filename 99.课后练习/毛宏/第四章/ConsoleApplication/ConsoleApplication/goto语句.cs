using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class goto语句
    {
        public static void Main()
        {
            start:
            int myInteger = 5;
            goto addVal;
            writeResult:
            Console.WriteLine("myInteger = {0}", myInteger);
            goto start;
            addVal:
            myInteger += 10;
            goto writeResult;
        }
    }
}
