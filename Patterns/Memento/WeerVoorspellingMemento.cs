using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weervoorspelling.Patterns.Memento
{
    internal class WeerVoorspellingMemento
    {
        public string Description { get; private set; }
        public double TemperatureDay { get; private set; }
        public double TemperatureNight { get; private set; }
        public double Humidity { get; private set; }

        public WeerVoorspellingMemento(string description, double tempDay, double tempNight, double humidity)
        {
            Description = description;
            TemperatureDay = tempDay;
            TemperatureNight = tempNight;
            Humidity = humidity;
        }
    }
}