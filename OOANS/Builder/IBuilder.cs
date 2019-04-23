using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Builder
{
    interface IBuilder
    {
        IBuilder AddAttachment(File file);
        IBuilder AddRoom(Room room);
        IBuilder AddText(string text);
        IBuilder AddUser(User user);
        Message Build();
    }
}
