using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOANS.Builder;
using OOANS.Windows;

namespace OOANS
{
    class RoomManager
    {
        private Director director = new Director();
        public RoomWindow window;

        public void SendMessage(List<Room> roomsToSend)
        {
            string attType = "file";
            // get inputs from room window (attachment type too)
            director.ChangeBuilder(attType);
            var builder = director.Builder;
            builder.AddRoom(new Room()); // room obtained from RoomWindow
            builder.AddUser(new User()); // user obtained from RoomWindow
            // foreach attachment obtained from room add
            builder.AddAttachment(new File()); // attachment obtained from RoomWindow
            builder.AddText("message text"); // text obtained from RoomWindow
        }
    }
}
