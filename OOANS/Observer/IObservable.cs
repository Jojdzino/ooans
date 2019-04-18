using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Observer
{
    interface IObservable
    {
        void NotifyObservers(Message message);
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
    }
}
