using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class Controller: IController
    {
        IModel model;
        IAction action;

        public IModel Model
        {
            set
            {
                model = value;
            }
        }

        public Controller(IModel model)
        {
            Model = model;
            action = new Action(model);
        }

        public IPaint PaintController
        {
            get
            {
                return model.PaintController;
            }
        }

        public IAction Action
        {
            get
            {
                return action;
            }
        }
    }
}
