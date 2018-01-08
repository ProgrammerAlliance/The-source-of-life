using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Operation
{
    public class MemoryFactory
    {
        public IMemory CreateMemory(Enum.OperateEnum operateEnum)
        {
            IMemory memory = null;
            switch (operateEnum)
            {
                case Enum.OperateEnum.MAdd:
                    memory = new MemoryA
                    break;
            }
        }
    }
}
