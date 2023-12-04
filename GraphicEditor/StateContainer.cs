using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class StateContainer : IAction
    {
        // Активное состояние 
        public State State { get; set; }
        public StateContainer(State state)
        {
            State = state;
        }

        public void MouseDown(int x, int y)
        {
            State.MouseDown(x, y, this);
        }

        public void MouseMove(int x, int y)
        {
            State.MouseMove(x, y, this);
        }

        public void MouseUp(int x, int y)
        {
            State.MouseUp(x, y, this);
        }
    }
}
