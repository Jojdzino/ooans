using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Command
{
    class BrushCommand : ICommand
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
            // Draw to calculated points with brush
            Console.WriteLine("Drawing with brush command");
        }

        public void Undo()
        {
            // UnDraw calculated points with brush
            Console.WriteLine("Undoing with brush command");
        }
    }
}
