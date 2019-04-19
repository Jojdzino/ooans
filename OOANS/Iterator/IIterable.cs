using OOANS.Iterator;
using System.Collections;

namespace OOANS
{
    public interface IIterable
    {
        string UserName { get; set; }

        IIterator GetIterator(string name);
    }
}