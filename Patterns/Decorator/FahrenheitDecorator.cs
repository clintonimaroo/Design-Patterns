using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weervoorspelling.Patterns.Memento;
using Weervoorspelling.Patterns.Strategy;

namespace Weervoorspelling.Patterns.Decorator
{
    internal class FahrenheitDecorator : WeatherForecastDecorator
    {
        public FahrenheitDecorator(IForecastStrategy innerForecastStrategy) : base(innerForecastStrategy) { }

        public override void DisplayForecast(WeerVoorspelling forecast)
        {
            forecast.TemperatureDay = forecast.TemperatureDay * 9 / 5 + 32;
            forecast.TemperatureNight = forecast.TemperatureNight * 9 / 5 + 32;
            base.DisplayForecast(forecast);
        }
    }
}