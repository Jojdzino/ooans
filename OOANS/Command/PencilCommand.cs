using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Command
{
    class PencilCommand : ICommand
    {
        List<Point> points;

        public void Draw(Point start, Point end)
        {
            // calculate all points to draw, and fill variable points
            // ...
            Execute();
        }

        public void Execute()
        {
            // Draw to calculated points with pencil
            Console.WriteLine("Drawing with pencil command");
        }

        public void Undo()
        {
            // UnDraw calculated points with pencil
            Console.WriteLine("Undoing with pencil command");
        }
    }
}
