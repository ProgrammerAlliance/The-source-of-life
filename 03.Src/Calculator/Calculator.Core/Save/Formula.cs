using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
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

        /// <summary>
        /// 返回运算字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }

}
