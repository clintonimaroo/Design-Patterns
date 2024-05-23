using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weervoorspelling.Patterns.Prototype
{
    internal class PrototypeWeervoorspelling : ICloneable
    {
        public string Description { get; set; } = string.Empty; 
        public double TemperatureDay { get; set; }
        public double TemperatureNight { get; set; }
        public double Humidity { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}