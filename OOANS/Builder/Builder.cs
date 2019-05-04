using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Builder
{
    abstract class Builder : IBuilder
    {
        public File File { get; set; }
        public Room Room { get; set; }
        public string Text { get; set; }
        public User User { get; set; }
        public List<File> Attachments { get; set; }


        public abstract IBuilder AddAttachment(File file);

        public IBuilder AddRoom(Room room)
        {
            Room = room;
            return this;
        }

        public IBuilder AddText(string text)
        {
            Text = text;
            return this;
        }

        public IBuilder AddUser(User user)
        {
            User = user;
            return this;
        }

        public Message Build()
        {
            return new Message(new MessageDTO(User, Room, Text, Attachments));
        }
    }
}
