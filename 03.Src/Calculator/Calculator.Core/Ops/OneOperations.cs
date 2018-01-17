﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Core.SDK;
using Calculator.Core.Operation.Enum;

namespace Calculator.Core.Ops
{
    public class OneOperations : IOps
    {
        SpecialEnum _op;

        public OneOperations(SpecialEnum op)
        {
            this._op = op;
        }
        public Expression Process(Expression exp)
        {
            if (true)
            {

            }
            var oldRExp = exp.RExp;
            exp.RExp = new Expression
            {
                L = exp.L.Length == 0 ? "0" : exp.L,
                R = exp.R,
                Opt = this._op,
                RExp = oldRExp
            };
            exp.R = exp.RExp.DoCalc();
            exp.RExp.L = null;
            exp.EV = exp.R;
            return exp;
        }
    }
}