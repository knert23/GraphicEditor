using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class Action: IAction
    {
        StateContainer stateContainer;

        public Action(StateContainer stateContainer)
        {
            this.stateContainer = stateContainer;
        }

        public void MouseDown(int x, int y)
        {
            stateContainer.MouseDown(x, y);
        }

        public void MouseUp(int x, int y)
        {
            stateContainer.MouseUp(x, y);
        }

        public void MouseMove(int x, int y)
        {
            stateContainer.MouseMove(x, y);
        }
    }
}
