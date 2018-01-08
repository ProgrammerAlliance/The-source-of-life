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

        OperateEnum sybEnum = OperateEnum.first;

        private double n = 0;


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

        /// <summary>
        /// 普通运算方法
        /// </summary>
        /// <param name="oe"></param>
        /// <param name="syb"></param>
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

        /// <summary>
       /// 特殊运算方法
       /// </summary>
       /// <param name="se"></param>
       /// <param name="syb"></param>
        public void SpecOperation(SpecialEnum se, string syb)
        {

        }

        /// <summary>
        /// C、CE、Bac方法
        /// </summary>
        /// <param name="ce"></param>
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
        /// 记忆功能方法
        /// </summary>
        /// <param name="me"></param>
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

        /// <summary>
        /// 历史记录
        /// </summary>
        /// <param name="key"></param>
        public void SelectHisory(string key)
        {

        }
        

    }
}
