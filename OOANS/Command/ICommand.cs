using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Command
{
    interface ICommand
    {
        void Draw(Point start, Point end);
        void Execute();
        void Undo();
    }
}
