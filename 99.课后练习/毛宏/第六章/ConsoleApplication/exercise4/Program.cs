using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  修改下面的结构，使之包含一个返回订单总价格的函数。
struct order
{
public string itemName;
public int unitCount;
public double unitCost;
}
*/
namespace exercise4
{
    class Program
    {
        struct order
        {
            public string itemName;
            public int unitCount;
            public double unitCost;
            public double TotalCost()
            {
                return unitCount * unitCost;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
