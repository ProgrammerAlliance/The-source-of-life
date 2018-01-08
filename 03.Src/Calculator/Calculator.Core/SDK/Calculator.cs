using Calculator.Core.Save;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{

    public class Calculator
    {
        public Formulas Formulas { get; set; }

        public string Result { get; set; }

        public Historys Historys { get; set; }

        public Memorys Memorys { get; set; }

        public Calculator()
        {

        }

        public void CalcOperation(string op)
        {
            string regexNum = @"([0-9])|([\.])";
            string regexSymbol = @"([+\-*/])";
        }

        public void MemoryOperation(string key, string op)
        {
            
        }

        public void MemoryOperation(string op)
        {

        }

        public void SelectHistory(string key)
        {
            if (Historys == null) return;

            var his = Historys.Select(key);

            if (his == null)
            {
                throw new Exception("历史记录不存在");
            }


        }

    }
}
