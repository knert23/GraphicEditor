using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class CreateState: State
    {
        public CreateState(Model model) : base(model) { }

        public override void MouseDown(int x, int y, StateContainer stateContainer) 
        {
            // Начальное создание объекта (можно растянуть до нужного размера)
            model.Creator.CreateObject(x, y);
            model.SelectDealer.TrySelect(x, y);
            if (model.SelectDealer.TryGrab(x, y))
            {
                // Переход в другое активное состояние
                stateContainer.State = new DragState(model);
            }
        }
    }
}