using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Save
{
    public class Formula
    {
        public string Input { get; set; }
    }

    public class Formulas : List<Formula>
    {
        public void Op(string op)
        {

        }

        public void CE()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}
