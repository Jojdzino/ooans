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

        public void ChangeBuilder()
        {

        }

        public Message Make()
        {
            return Builder.Build();
        }

    }
}
