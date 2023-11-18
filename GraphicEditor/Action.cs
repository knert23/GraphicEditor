using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class Action: IAction
    {
        IModel model;
        public Action(IModel model)
        {
            this.model = model;
        }
        public ObjectType ObjectType { get; set; }

        public void MouseUp(int x, int y)
        {
            model.Creator.ObjectType = ObjectType;
            model.Creator.CreateObject(x, y);
        }
    }
}
