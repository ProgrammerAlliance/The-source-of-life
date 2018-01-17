using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public interface IOperation
    {
        double GetResult(double number1, double number2);

        string ToString(string number1, string number2);
     
    }
}
