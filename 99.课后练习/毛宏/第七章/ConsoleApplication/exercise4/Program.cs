using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 下面定义了一个枚举数据类型 orientation。编写一个应用程序，使用结构化异常处理(SEH)
把 byte 类型的变量安全地强制转换为 orientation 类型变量。注意，可以使用 checked 关键字强制抛
出异常，下面是一个示例。可以在应用程序中使用这段代码：
enum Orientation : byte
{
North = 1,
South = 2,
East = 3,
West = 4
}
myDirection = checked((Orientation)myByte);
*/
namespace exercise4
{
    class Program
    {
        enum Orientation : byte
        {
            North = 1,
            South = 2,
            East = 3,
            West = 4
        }
        static void Main(string[] args)
        {
            Orientation myDirection;
            for (byte myByte = 2; myByte < 10; myByte++)
            {
                try
                {
                    myDirection = checked((Orientation)myByte);
                    if ((myDirection < Orientation.North) ||
                    (myDirection > Orientation.West))
                    {
                        throw new ArgumentOutOfRangeException("myByte", myByte,
                        "Value must be between 1 and 4");
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    // If this section is reached then myByte < 1 or myByte > 4.
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Assigning default value, Orientation.North.");
                    myDirection = Orientation.North;
                }
                Console.WriteLine("myDirection = {0}", myDirection);
            }
        }
    }
}
