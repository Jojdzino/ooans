using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS
{
    public class MessageDTO
    {
        public string Text { get; set; }
        private IList<File> _attachments;
        private User _from;
        private User _to;

        public MessageDTO(User from, User to, string text)
        {
            this._from = from;
            this._to = to;
            this.Text = text;
        }

        public void AddAtachment(File file)
        {
            this._attachments.Add(file);
        }
    }
}
