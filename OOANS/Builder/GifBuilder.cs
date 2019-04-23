using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Builder
{
    class GifBuilder : Builder
    {
        public override IBuilder AddAttachment(File file)
        {
            if (!(file is Gif))
            {
                return this;
            }

            Attachments = Attachments ?? new List<File>();
            Attachments.Add(file);
            return this;
        }
    }
}
