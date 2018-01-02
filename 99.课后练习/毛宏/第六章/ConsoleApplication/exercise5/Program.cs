using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 在 order 结构中添加另一个函数，该结构返回一个格式化的字符串(一行文本，以合适的值
替换用尖括号括起来的斜体条目)。
Order Information: <unit count> <item name> items at $<unit cost> each,
total cost $<total cost>
*/
namespace exercise5
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
            public string Info()
            {
                return "Order information: " + unitCount.ToString() + " " + itemName +
                " items at $" + unitCost.ToString() + " each, total cost $" +
                TotalCost().ToString();
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
