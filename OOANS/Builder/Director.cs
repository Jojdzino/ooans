using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Builder
{
    class Director
    {
        public IBuilder Builder { get; private set; }

        public void ChangeBuilder(string type)
        {
            switch(type)
            {
                case "photo":
                    {
                        Builder = new PhotoBuilder();
                        break;
                    }
                case "file":
                    {
                        Builder = new FileBuilder();
                        break;
                    }
                case "gif":
                    {
                        Builder = new GifBuilder();
                        break;
                    }
                default: break;
            }
        }

        public Message Make()
        {
            return Builder.Build();
        }

    }
}
