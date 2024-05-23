using System;
using Weervoorspelling.Patterns.Memento;
using Weervoorspelling.Patterns.Observer;
using Weervoorspelling.Patterns.Strategy;
using Weervoorspelling.Patterns.Prototype;
using Weervoorspelling.Patterns.Decorator;

namespace Weervoorspelling
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherForecast = new WeerVoorspelling
            {
                Description = "Sunny",
                TemperatureDay = 20,
                TemperatureNight = 10,
                Humidity = 50
            };

            // Memento
            var beheerder = new Beheerder();
            beheerder.Save(weatherForecast.SaveMemento());

            // Observer
            var weerOnderwerp = new WeerOnderwerp();
            var userObserver = new UserObserver();
            weerOnderwerp.Attach(userObserver);

            weerOnderwerp.SetTemperature(weatherForecast.TemperatureDay);

            // Strategy
            IForecastStrategy strategy = new GedetailleerdeForecastStrategy();
            strategy.DisplayForecast(weatherForecast);

            // Prototype
            var prototype = new PrototypeWeervoorspelling
            {
                Description = "Cloudy",
                TemperatureDay = 15,
                TemperatureNight = 8,
                Humidity = 70
            };

            var clonedForecast = (PrototypeWeervoorspelling)prototype.Clone();
            clonedForecast.Description = "Rainy";

            Console.WriteLine("\nCloned Forecast:");
            Console.WriteLine($"Description: {clonedForecast.Description}");

            // Decorator
            IForecastStrategy simpleStrategy = new SimpleForecastStrategy();
            IForecastStrategy decoratedStrategy = new CelsiusDecorator(simpleStrategy);
            decoratedStrategy.DisplayForecast(weatherForecast);

            decoratedStrategy = new FahrenheitDecorator(simpleStrategy);
            decoratedStrategy.DisplayForecast(weatherForecast);

            // Undo (Memento)
            weatherForecast.RestoreMemento(beheerder.Undo());
            Console.WriteLine("\nRestored Forecast:");
            strategy.DisplayForecast(weatherForecast);
        }
    }
}


