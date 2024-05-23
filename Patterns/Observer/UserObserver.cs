using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weervoorspelling.Patterns.Observer
{
    internal class UserObserver : IObserver
    {
        public void Update(double temperatureDay)
        {
            if (temperatureDay > 15)
            {
                Console.WriteLine("Melding: Temperatuur is boven de 15 graden.");
            }
        }
    }
}