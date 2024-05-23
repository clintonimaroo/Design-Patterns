﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weervoorspelling.Patterns.Observer
{
    internal interface IObserver
    {
        void Update(double temperatureDay);
    }
}