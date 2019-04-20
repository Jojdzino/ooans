using OOANS.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Windows
{
    class EditingWindow
    {
        public Stack<ICommand> Commands { get; private set; }
        private ICommand actualCommand;

        // drawing on image canvas
        public void Draw()
        {
            if (actualCommand != null)
            {
                actualCommand.Execute();
                Commands.Push(actualCommand);
                actualCommand = null;
            }
        }

        // click on brush button
        public void PickBrush()
        {
            actualCommand = new BrushCommand();
        }

        // click on pencil button
        public void PickPencil()
        {
            actualCommand = new PencilCommand();
        }

        public void Undo()
        {
            Commands.Pop().Undo();
        }
    }
}
