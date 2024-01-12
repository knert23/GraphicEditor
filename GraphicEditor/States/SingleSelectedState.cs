using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.States
{
    class SingleSelectedState: State
    {
        public SingleSelectedState(Model model) : base(model) 
        {
            model.PaintController.RefreshMarkers();
        }

        public override void ShiftMouseUp(int x, int y, StateContainer stateContainer)
        {
            stateContainer.State = new MultiSelectState(model);
            stateContainer.State.ShiftMouseUp(x, y, stateContainer);
        }

        public override void MouseUp(int x, int y, StateContainer stateContainer)
        {
            if (model.SelectDealer.TrySelect(x, y))
            {
                model.PaintController.Refresh();
                model.PaintController.RefreshMarkers();
            }
        }

        public override void MouseDown(int x, int y, StateContainer stateContainer)
        { 
            if (model.SelectDealer.TryGrab(x, y))
            {
                stateContainer.State = new DragState(model);
            } 
        }

        public override void MouseMove(int x, int y, StateContainer stateContainer)
        {
            if (model.SelectDealer.TryReplace(x, y))
            {
                model.PaintController.Refresh();
                model.PaintController.RefreshMarkers();
            }
        }

        public override void Esc(StateContainer stateContainer)
        {
            model.SelectDealer.SelectionStore.Clear();
            model.PaintController.Refresh();
            stateContainer.State = new EmptyState(model);
        }

        public override void Del(StateContainer stateContainer)
        {
            model.SelectDealer.DeleteSelected();
            model.PaintController.Refresh();
            stateContainer.State = new EmptyState(model);
        }

        public override void Ungroup(StateContainer stateContainer)
        {
            model.SelectDealer.Ungroup();
            model.PaintController.Refresh();
            model.PaintController.RefreshMarkers();
            stateContainer.State = new MultiSelectState(model);
        }
    }
}
