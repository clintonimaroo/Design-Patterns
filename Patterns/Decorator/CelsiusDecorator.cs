using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weervoorspelling.Patterns.Memento;
using Weervoorspelling.Patterns.Strategy;

namespace Weervoorspelling.Patterns.Decorator
{
    internal class CelsiusDecorator : WeatherForecastDecorator
    {
        public CelsiusDecorator(IForecastStrategy innerForecastStrategy) : base(innerForecastStrategy) { }

        public override void DisplayForecast(WeerVoorspelling forecast)
        {
            base.DisplayForecast(forecast);
        }
    }
}