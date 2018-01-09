using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class Symbol
    {

        /// <summary>
        /// 处理显示的符号
        /// </summary>
        /// <param name="syb"></param>
        public void ProcessSymbol(string syb,string lastFormula,string input)
        {
            if (lastIsSymbol && Lab_Formula.Length - 1 > 0)
            {
                Lab_Formula = Lab_Formula.Remove(Lab_Formula.Length - 1) + syb;
                return;
            }
            double strLab = Convert.ToDouble(Lab_Answer);
            _lab_Formula += strLab.ToString() + syb;
        }

    }
}
