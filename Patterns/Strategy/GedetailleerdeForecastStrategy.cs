using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weervoorspelling.Patterns.Memento;

namespace Weervoorspelling.Patterns.Strategy
{
    internal class GedetailleerdeForecastStrategy : IForecastStrategy
    {
        public void DisplayForecast(WeerVoorspelling forecast)
        {
            Console.WriteLine($"Description: {forecast.Description}");
            Console.WriteLine($"Temperature Day: {forecast.TemperatureDay}°C");
            Console.WriteLine($"Temperature Night: {forecast.TemperatureNight}°C");
            Console.WriteLine($"Humidity: {forecast.Humidity}%");
        }
    }
}