using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOANS.Windows;

namespace OOANS
{
    class Program
    {
        static void Main(string[] args)
        {
            RoomWindow rw = new RoomWindow();
            Room r = new Room();
            // TOOD: odniekal ho bude treba registrovat .. konstruktor ? pripadne pri vytvarani v builderi ?
            r.RegisterObserver(rw);

            r.AddMessage(new Message() { Text = "test message" });

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
