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
        public void StartCreate(ObjectType objectType, StateContainer stateContainer)
        {
            model.SelectDealer.TryRelease(); // надо ли?
            stateContainer.State = new CreateState(model, objectType); // удалить из Settings свойство ObjectType
        }
        public virtual void Esc(StateContainer stateContainer) { }
        public virtual void Del(StateContainer stateContainer) { }
        public virtual void ShiftMouseUp(int x, int y, StateContainer stateContainer) { }
        public virtual void Group(StateContainer stateContainer) { }
        public virtual void Ungroup(StateContainer stateContainer) { }
    }
}
