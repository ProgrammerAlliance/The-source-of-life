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

        public Formulas Formulas { get; set; }

        private bool _lastIsSymbol = false;

        OperateEnum sybEnum = OperateEnum.first;

        private double n = 0;









        /// <summary>
        /// 界面数字调用方法
        /// </summary>
        /// <param name="op"></param>
        public void CalcNumber(string op)
        {
            
            if (".".Equals(op))
            {
                Point point = new Point();
                Result = point.InputPoint(op, _lastIsSymbol, Result);
            }
            else
            {
                Number number = new Number();
                Result = number.ProcessNum(op, _lastIsSymbol, Result);
            }

            _lastIsSymbol = false;
        }

        /// <summary>
        /// 普通运算方法
        /// </summary>
        /// <param name="oe"></param>
        /// <param name="syb"></param>
        public void CalcOperation(OperateEnum oe, string syb)
        {
            switch (oe)
            {
                case OperateEnum.Equal:
                    Equal(syb);
                    break;
            }

            //double num2 = Convert.ToDouble(screenInput.Lab_Answer);

            //screenInput.ProcessSymbol(syb, _lastIsSymbol);
            //if (!_lastIsSymbol)
            //{
            //    if (OperationFactory.CreatOperation(sybEnum) == null)
            //    {
            //        n = Convert.ToDouble(num2);
            //    }
            //    else
            //    {
            //        n = OperationFactory.CreatOperation(sybEnum).GetResult(n, num2);
            //    }
            //}
            //screenInput.Lab_Answer = n.ToString();
            //sybEnum = oe;
            //_lastIsSymbol = true;

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

                    n = 0;
                    sybEnum = OperateEnum.first;
                    _lastIsSymbol = false;
                    break;
                case ClearEnum.CE:
                    Formulas.CE();
                    break;
                case ClearEnum.Del:
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


        public void Equal(string syb)
        {
            Historys.Add(new History());//添加history

            //计算

            Historys[Historys.Count - 1].Formula = Formulas.ToString() + syb;//向history添加算式
            Historys[Historys.Count - 1].Result = Result;//向history添加结果
            Formulas.Clear(); //清除已写入历史记录的Formula?
        }
    }
}
