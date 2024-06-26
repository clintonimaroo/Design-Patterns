﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weervoorspelling.Patterns.Observer
{
    internal interface IOnderwerp
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}