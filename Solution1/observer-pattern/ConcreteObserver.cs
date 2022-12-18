using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    internal class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is Subject castedSubject && castedSubject.State == 10)
            {
                Console.WriteLine("I'm here ConcreteObserver1");
            }
        }
    }

    internal class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is Subject castedSubject && castedSubject.State == 5)
            {
                Console.WriteLine("I'm here ConcreteObserver1");
            }
        }
    }
}
