using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Iterator
{
    public class AllUsersIterator : IIterator
    {
        public Room Room
        {
            get
            {
                return this._room;
            }
            set
            {
                this.messages = value.Messages;
                this._room = value;
            }
        }
        private IList<Message> messages = new List<Message>();
        private Room _room;
        private int index = 0;

        public bool HasNext()
        {
            return (index < messages.Count) ? true : false;
        }

        public Message Next()
        {
            if (HasNext()) {
                index++;
                return messages[index - 1];
            }
            return null;
        }
    }
}
