using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*在类库项目 Vehicle 中编写代码，实现本章前面时论的对象系列 Vehicle，其中有 9 个对象和
2 个接口需要实现。
*/
namespace Vehicle
{
    public class Vehicle
    {
    }
    public abstract class Car : Vehicle
    {
    }
    public abstract class Train : Vehicle
    {
    }
    public interface IPassengerCarrier
    {
    }
    public interface IHeavyLoadCarrier
    {
    }
    public class SUV : Car, IPassengerCarrier
    {
    }
    public class Pickup : Car, IPassengerCarrier, IHeavyLoadCarrier
    {
    }
    public class Compact : Car, IPassengerCarrier
    {
    }
    public class PassengerTrain : Train, IPassengerCarrier
    {
    }
    public class FreightTrain : Train, IHeavyLoadCarrier
    {
    }
    public class T424DoubleBogey : Train, IHeavyLoadCarrier
    {
    }
}
