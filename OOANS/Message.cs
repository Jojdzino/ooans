using OOANS.Decorator;
using OOANS.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS
{
    public class Message : IComponent
    {
        public string Text { get; set; }
        public User SentFrom { get; internal set; }
        public MessageDTO MessageDTO {get;set;}
        private MessageMementoCaretaker _caretaker = new MessageMementoCaretaker();

        public Message(MessageDTO messageDTO)
        {
            MessageDTO = messageDTO;
        }

        public override string ToString()
        {
            return Text;
        }

        public bool CreateMemento(MessageDTO memento)
        {
            return _caretaker.CreateMemento(memento);
        }

        public MessageDTO RestoreMemento(int index)
        {
            this.MessageDTO = _caretaker.GetMemento(index);
            return this.MessageDTO;
        }

        public string ShowMessage()
        {
            return Text;
        }
    }
}
