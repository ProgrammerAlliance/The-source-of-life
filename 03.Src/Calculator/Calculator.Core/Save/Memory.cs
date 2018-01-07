using System.Collections.Generic;

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
