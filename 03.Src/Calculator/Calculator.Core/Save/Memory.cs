using Calculator.Core.SDK;
using System;
using System.Collections.Generic;

namespace Calculator.Core
{
    /// <summary>
    /// 存储类
    /// </summary>
    public class Memory
    {
        /// <summary>
        /// Memory中存储的数
        /// </summary>
        public string MemoryNumber = "0";

        /// <summary>
        /// M+方法
        /// </summary>
        /// <param name="exp"></param>
        public void Add(Expression exp)
        {
            double Mnum = Convert.ToDouble(MemoryNumber) + Convert.ToDouble(exp.EV);
            MemoryNumber = Mnum.ToString();
        }

        /// <summary>
        /// M-方法
        /// </summary>
        /// <param name="exp"></param>
        public void Sub(Expression exp)
        {
            double Mnum = Convert.ToDouble(MemoryNumber) - Convert.ToDouble(exp.EV);
            MemoryNumber = Mnum.ToString();
        }

        /// <summary>
        /// MC方法
        /// </summary>
        public void Clear()
        {
            MemoryNumber = "0";
        }

        /// <summary>
        /// MS方法
        /// </summary>
        /// <param name="exp"></param>
        public void Save(Expression exp)
        {
            MemoryNumber = exp.EV;
        }

        /// <summary>
        /// MR方法
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public Expression Read(Expression exp)
        {
            exp.R = MemoryNumber;
            exp.EV = MemoryNumber;
            return exp;
        }
    }
}
