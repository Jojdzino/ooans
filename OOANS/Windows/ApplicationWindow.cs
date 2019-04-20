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
        private static ApplicationWindow instance;
        public static ApplicationWindow Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApplicationWindow();
                }
                return instance;
            }
            private set { instance = value; }
        }

        private ApplicationWindow() { }



        public void Update(Message message)
        {
            Console.WriteLine(GetType() + " - received update with message: " + message);
        }
    }
}
