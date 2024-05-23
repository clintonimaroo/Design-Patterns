using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weervoorspelling.Patterns.Observer
{
    internal class WeerOnderwerp : IOnderwerp
    {
        private List<IObserver> _observers = new List<IObserver>();
        public double TemperatureDay { get; private set; }

        public void SetTemperature(double temperature)
        {
            TemperatureDay = temperature;
            Notify();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(TemperatureDay);
            }
        }
    }
}