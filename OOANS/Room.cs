using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOANS.Observer;

namespace OOANS
{
    class Room : IObservable
    {
        // TODO: upravit model, chyba tam parameter
        private List<IObserver> observers = new List<IObserver>();

        public void AddMessage(Message message)
        {
            NotifyObservers(message);
        }

        // TODO: upravit model, chyba tam parameter
        public void NotifyObservers(Message message)
        {
            foreach(var o in observers)
            {
                o.Update(message);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            if(!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
