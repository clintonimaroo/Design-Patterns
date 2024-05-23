using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weervoorspelling.Patterns.Memento
{
    internal class Beheerder
    {
        private Stack<WeerVoorspellingMemento> _mementos = new Stack<WeerVoorspellingMemento>();

        public void Save(WeerVoorspellingMemento memento)
        {
            _mementos.Push(memento);
        }

        public WeerVoorspellingMemento? Undo() 
        {
            if (_mementos.Count > 0)
            {
                return _mementos.Pop();
            }
            return null;
        }
    }
}