using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Decorator
{
    public interface Decorator : IComponent
    {
        IComponent Component { get; set; }

        void SetStringValue(string strVal);
    }
}
