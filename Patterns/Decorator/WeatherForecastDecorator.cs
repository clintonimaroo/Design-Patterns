using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weervoorspelling.Patterns.Memento;
using Weervoorspelling.Patterns.Strategy;

namespace Weervoorspelling.Patterns.Decorator
{
    internal class WeatherForecastDecorator : IForecastStrategy
    {
        protected IForecastStrategy _innerForecastStrategy;

        public WeatherForecastDecorator(IForecastStrategy innerForecastStrategy)
        {
            _innerForecastStrategy = innerForecastStrategy;
        }

        public virtual void DisplayForecast(WeerVoorspelling forecast)
        {
            _innerForecastStrategy.DisplayForecast(forecast);
        }
    }
}