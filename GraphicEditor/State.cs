using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    abstract class State
    {
        protected Model model;

        public State(Model model)
        {
            this.model = model;
        }

        public Model Model { set => model = value; }

        public virtual void MouseUp(int x, int y, StateContainer stateContainer) { }
        public virtual void MouseDown(int x, int y, StateContainer stateContainer) { }
        public virtual void MouseMove(int x, int y, StateContainer stateContainer) { }
    }
}
