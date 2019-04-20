using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS
{
    public class Message
    {
        public string Text { get; set; }
        public User SentFrom { get; internal set; }
        public MessageDTO MessageDTO {get;set;}

        public override string ToString()
        {
            return Text;
        }
    }
}
