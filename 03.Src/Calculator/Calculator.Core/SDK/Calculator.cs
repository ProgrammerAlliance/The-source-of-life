using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{

    public class Calculator
    {

        public string Result { get; set; }

        public Historys Historys { get; set; }

        public Memorys Memorys { get; set; }

        public Formulas Forlmulas { get; set; }

        private bool _lastIsSymbol = false;

        ScreenInput screenInput = new ScreenInput();

        OperateEnum sybEnum = OperateEnum.first;

        private double n = 0;


        public void CalcOperation(OperateEnum oe, string syb)
        {

            double num2 = Convert.ToDouble(screenInput.Lab_Answer);

            screenInput.ProcessSymbol(syb, _lastIsSymbol);
            if (!_lastIsSymbol)
            {
                if (OperationFactory.CreatOperation(sybEnum) == null)
                {
                    n = Convert.ToDouble(num2);
                }
                else
                {
                    n = OperationFactory.CreatOperation(sybEnum).GetResult(n, num2);
                }
            }
            screenInput.Lab_Answer = n.ToString();
            sybEnum = oe;
            _lastIsSymbol = true;

        }

        public void Equal()
        {

            screenInput.Lab_Formula = "";
            try
            {
                screenInput.Lab_Answer = OperationFactory.CreatOperation(sybEnum).GetResult(n, double.Parse(screenInput.Lab_Answer)).ToString();
                //n = 0;
            }catch(NullReferenceException)
            {
                
            }

        }
        public void SpecOperation(SpecialEnum se, string syb)
        {

        }

        public void MOperation(MEnum me)
        {
            switch (me)
            {
                case MEnum.MRead:
                    {
                        Result = Memorys.MemoryRead().ToString();
                        break;
                    }
                case MEnum.MSave:
                    {
                        Memorys.MemorySave(Convert.ToDouble(Result));
                        break;
                    }
                case MEnum.MClear:
                    {
                        Memorys.Clear();
                        break;
                    }
                case MEnum.MAdd:
                    {
                        Memorys.MemoryAdd(Convert.ToDouble(Result));
                        break;
                    }
                case MEnum.MSub:
                    {
                        Memorys.MemorySub(Convert.ToDouble(Result));
                        break;
                    }
            }
        }

        public void ClearOperation(ClearEnum ce)
        {
            switch (ce)
            {
                case ClearEnum.C:
                    screenInput = new ScreenInput();
                    n = 0;
                    sybEnum = OperateEnum.first;
                    _lastIsSymbol = false;
                    break;
                case ClearEnum.CE:

                    break;
                case ClearEnum.Del:

                    break;
                case ClearEnum.Invert:

                    break;
            }
        }

        /// <summary>
        /// 界面数字调用方法
        /// </summary>
        /// <param name="op"></param>
        public void CalcNumber(string op)
        {
            if (".".Equals(op)) { screenInput.Point(op, _lastIsSymbol); }
            else { screenInput.ProcessNum(op, _lastIsSymbol); }
            _lastIsSymbol = false;
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





        public string GetFormula()
        {
            return screenInput.Lab_Formula;
        }
        public string GetAnswer()
        {
            return screenInput.Lab_Answer;
        }
        public string GetRegister()
        {
            return screenInput.Lab_Register;
        }


    }
}
