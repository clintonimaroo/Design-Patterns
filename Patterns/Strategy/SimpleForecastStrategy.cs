using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weervoorspelling.Patterns.Memento;

namespace Weervoorspelling.Patterns.Strategy
{
    internal class SimpleForecastStrategy : IForecastStrategy
    {
        public void DisplayForecast(WeerVoorspelling forecast)
        {
            Console.WriteLine($"Temperature Day: {forecast.TemperatureDay}°C");
        }
    }
}