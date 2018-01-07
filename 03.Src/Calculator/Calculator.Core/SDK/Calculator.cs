using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{

    public class Calculator
    {
        private List<string> _Formula { get; set; }
        public string Formula { get { return ""; } }

        public string Result { get; set; }

        public Historys Historys { get; set; }

        public Memorys Memorys { get; set; }

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

        public void SelectHisory(string key)
        {

        }


        


    }
}
