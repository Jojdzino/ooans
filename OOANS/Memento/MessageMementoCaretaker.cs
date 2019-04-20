using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Memento
{
    public class MessageMementoCaretaker
    {
        public int StackSize = 10;
        private IList<MessageDTO> _stack;

        public MessageDTO GetMemento(int index)
        {
            return _stack[index];
        }
        
        public bool CreateMemento(MessageDTO memento)
        {
            if(StackSize<=_stack.Count+1)
            {
                _stack.Add(memento);
                return true;
            }
            return false;
        }
    }
}
