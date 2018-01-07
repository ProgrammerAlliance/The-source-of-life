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

        private bool _lastIsSymbol = false;


        public void CalcOperation(OperateEnum oe)
        {

            OperationFactory.CreatOperation(oe);
        }

        public void SpecOperation(SpecialEnum se)
        {

        }

        public void MOperation(MEnum me)
        {

        }

        public void ClearOperation(ClearEnum ce)
        {

        }

        /// <summary>
        /// 界面数字调用方法
        /// </summary>
        /// <param name="op"></param>
        public void CalcNumber(string op)
        {

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
