using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weervoorspelling.Patterns.Memento
{
    internal class WeerVoorspelling
    {
        public string Description { get; set; } = string.Empty; 
        public double TemperatureDay { get; set; }
        public double TemperatureNight { get; set; }
        public double Humidity { get; set; }

        public WeerVoorspellingMemento SaveMemento()
        {
            return new WeerVoorspellingMemento(Description, TemperatureDay, TemperatureNight, Humidity);
        }

        public void RestoreMemento(WeerVoorspellingMemento memento)
        {
            Description = memento.Description;
            TemperatureDay = memento.TemperatureDay;
            TemperatureNight = memento.TemperatureNight;
            Humidity = memento.Humidity;
        }
    }
}