using System;
using System.Collections.Generic;

namespace Calculator.Core
{
    /// <summary>
    /// todo: wr
    /// </summary>
    public class Memory
    {
        public string Key { get; set; }

        /// <summary>
        /// Memory中存储的数
        /// </summary>
        public double MemoryNumber { get; set; }

        public void Add(double result)
        {
            MemoryNumber += result;
        }

        public void Sub(double result)
        {
            MemoryNumber -= result;
        }

    }

    public class Memorys : List<Memory>
    {
        public double MemoryRead()
        {
            if (this != null)
            {
                return this[Count - 1].MemoryNumber;
            }
            else
            {
                throw new Exception("内存中没有内容");
            }
        }

        public void MemorySave(double result)
        {
            Memory memory = new Memory();
            memory.Add(result);
            this.Add(memory);
        }

        public void MemoryAdd(double result)
        {
            if (this == null)
            {
                MemorySave(result);
            }
            else
            {
                this[Count - 1].Add(result);
            }
        }

        public void MemorySub(double result)
        {
            if (this == null)
            {
                Memory memory = new Memory();
                memory.Sub(result);
                this.Add(memory);
            }
            else
            {
                this[Count - 1].Sub(result);
            }
        }
    }

}
