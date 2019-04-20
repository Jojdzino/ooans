using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Builder
{
    class FileBuilder : IBuilder
    {
        public IBuilder AddAttachment(File file)
        {
            throw new NotImplementedException();
        }

        public IBuilder AddRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public IBuilder AddText()
        {
            throw new NotImplementedException();
        }

        public IBuilder AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public Message Build()
        {
            throw new NotImplementedException();
        }
    }
}
