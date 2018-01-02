using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle;


/*
 * 创建一个控制台应用程序项目 Traffic，它引用 Vehicles.dll(在第(4)题中创建)，其中包括函数
AddPassenger()，它接收任何带有 IPassengerCarrier 接口的对象。要证明代码可以运行，使用支持这
个接口的每个对象实例调用该函数，在每个对象上调用派生于 System.Object 的 ToString()方法，并
把结果输出到屏幕上。
*/
namespace Traffic
{
    class Program
    {
        static void Main(string[] args)
        {
            AddPassenger(new Compact());
            AddPassenger(new SUV());
            AddPassenger(new Pickup());
            AddPassenger(new PassengerTrain());
        }
        static void AddPassenger(IPassengerCarrier Vehicle)
        {
            Console.WriteLine(Vehicle.ToString());
        }
    }
}
