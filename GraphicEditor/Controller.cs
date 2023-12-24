using GraphicEditor.States;
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
        StateContainer stateContainer;
        Settings settings;
        ObjectStyleSettings objectStyleSettings;

        public IModel Model { set => model = value; }

        public Controller(IModel model)
        {
            Model = model;
            stateContainer = new StateContainer(new EmptyState((Model)model));
            action = new Action(stateContainer);
            objectStyleSettings = new ObjectStyleSettings(model);
            settings = new Settings(model, objectStyleSettings);
        }

        public IPaint PaintController { get => model.PaintController; }

        public IAction Action { get => action; }

        public ISettings Settings { get => settings; }
    }
}
