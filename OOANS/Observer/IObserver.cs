using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Observer
{
    interface IObserver
    {
        void Update(Message message);
    }
}
