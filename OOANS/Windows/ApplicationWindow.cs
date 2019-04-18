using OOANS.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Windows
{
    class ApplicationWindow : IObserver
    {
        public void Update(Message message)
        {
            Console.WriteLine(GetType() + " - received update with message: " + message);
        }
    }
}
