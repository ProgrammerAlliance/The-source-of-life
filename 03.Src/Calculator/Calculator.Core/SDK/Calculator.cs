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
            Result = Memorys[Convert.ToInt16(key)].MemoryNumber.ToString();
        }

        public void MemoryOperation(string op)
        {
            switch (op)
            {
                case "MR":
                    {
                        Result = Memorys.MemoryRead().ToString();
                        break;
                    }
                case "MS":
                    {
                        Memorys.MemorySave(Convert.ToDouble(Result));
                        break;
                    }
                case "MC":
                    {
                        Memorys.Clear();
                        break;
                    }
                case "M+":
                    {
                        Memorys.MemoryAdd(Convert.ToDouble(Result));
                        break;
                    }
                case "M-":
                    {
                        Memorys.MemorySub(Convert.ToDouble(Result));
                        break;
                    }
            }
            
        }

        public void SelectHisory(string key)
        {

        }


        


    }
}
