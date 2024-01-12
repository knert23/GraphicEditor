using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.States
{
    class MultiSelectState:State
    {
        public MultiSelectState(Model model) : base(model) { }

        public override void ShiftMouseUp(int x, int y, StateContainer stateContainer)
        {
            if (model.SelectDealer.TryAddSelection(x, y))
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

        public override void MouseUp(int x, int y, StateContainer stateContainer)
        {
            // Обнуляет расстояние от курсора
            for (int i = 0; i < model.SelectDealer.SelectionStore.Count; i++)
            {
                model.SelectDealer.SelectionStore[i].Distance = null;
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

        public override void Del(StateContainer stateContainer)
        {
            model.SelectDealer.DeleteSelected();
            model.PaintController.Refresh();
            stateContainer.State = new EmptyState(model);
        }

        public override void Group(StateContainer stateContainer)
        {
            model.SelectDealer.Group();
            model.PaintController.Refresh();
            stateContainer.State = new SingleSelectedState(model);
        }
    }
}
