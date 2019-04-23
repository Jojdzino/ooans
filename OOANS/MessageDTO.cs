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
        private Room _to;

        public MessageDTO(User from, Room to, string text, List<File> attachments)
        {
            this._from = from;
            this._to = to;
            this.Text = text;
            this._attachments = attachments;
        }

        public void AddAtachment(File file)
        {
            this._attachments.Add(file);
        }
    }
}
