﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator.Core
{
    public interface ISpecialOperation
    {
        double GeResult(double number);

        string GetString(double number);
    }
}