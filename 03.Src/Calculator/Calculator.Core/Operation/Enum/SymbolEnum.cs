using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public enum SymbolEnum
    {
        [Description("小数点")]
        Point = 1,

        [Description("正负号")]
        Sign = 2
    }
}
