﻿using GraphicEditor.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class DragState: State
    {
        public DragState(Model model) : base(model) { }

        public override void MouseUp(int x, int y, StateContainer stateContainer)
        {
            if (model.SelectDealer.TryRelease()) stateContainer.State = new SingleSelectedState(model);
        }
        public override void MouseMove(int x, int y, StateContainer stateContainer)
        {
            // Трансформация объекта
            if (model.SelectDealer.TryDrag(x, y))
            {
                model.PaintController.Refresh();
                model.PaintController.RefreshMarkers();
            }
                
        }
    }
}
