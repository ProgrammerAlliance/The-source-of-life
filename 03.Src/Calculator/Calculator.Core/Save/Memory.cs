using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    /// <summary>
    /// todo: wr
    /// </summary>
    public class Memory
    {
        /// <summary>
        /// Memory中存储的数
        /// </summary>
        public double Result { get; set; }

        public void Clear()
        {
            Result = 0;
        }

        public void Add(double num)
        {
            Result += num;
        }

        public void Sub(double num)
        {
            Result -= num;
        }

    }

    public class Memorys : List<Memory>
    {
    }

}
