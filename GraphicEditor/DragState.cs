﻿using System;
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
            // Конечное вид объекта
            if (model.SelectDealer.TryRelease(x, y))
            {
                stateContainer.State = new CreateState(model);
            }
        }
        public override void MouseMove(int x, int y, StateContainer stateContainer)
        {
            // Трансформация объекта
            if (model.SelectDealer.TryDrag(x, y)) model.PaintController.Refresh();
        }
    }
}
