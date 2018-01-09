using Calculator.Core.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Ops
{
    public interface IOps
    {
        Expression Process(Expression exp);
    }
}
