using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator.Core
{
    public interface ISpecialOperation
    {
        double GetResult(double number);

        string GetString(double number);
    }
}
