using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weervoorspelling.Patterns.Memento;

namespace Weervoorspelling.Patterns.Strategy
{
    internal interface IForecastStrategy
    {
        void DisplayForecast(WeerVoorspelling forecast);
    }
}