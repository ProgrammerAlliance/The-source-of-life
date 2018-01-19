using Calculator.Core.SDK;
using System;
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
        public string MemoryNumber = "0";

        public void Add(Expression exp)
        {
            double Mnum = Convert.ToDouble(MemoryNumber) + Convert.ToDouble(exp.EV); 
            MemoryNumber = Mnum.ToString();
        }

        public void Sub(Expression exp)
        {
            double Mnum = Convert.ToDouble(MemoryNumber) - Convert.ToDouble(exp.EV);
            MemoryNumber = Mnum.ToString();
        }

        public void Clear()
        {
            MemoryNumber = "0";
        }

        public void Save(Expression exp)
        {
            MemoryNumber = exp.EV;
        }

        public Expression Read(Expression exp)
        {
            exp.R = MemoryNumber;
            exp.EV = MemoryNumber;
            return exp;
        }
    }
}
