using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Iterator
{
    public interface IIterator
    {
        Room Room { get; set; }

        bool HasNext();
        Message Next();
        
    }
}
