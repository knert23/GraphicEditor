using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class Model: IModel
    {
        Scene scene;
        PaintController paintController;
        Painter painter;
        ObjectsStrore objectsStore;
        Factory factory;
        public Model()
        {
            objectsStore = new ObjectsStrore();
            painter = new Painter();
            factory = new Factory(objectsStore);
            scene = new Scene(objectsStore, painter);
            paintController = new PaintController(scene, painter);
        }
        public ICreator Creator
        {
            get
            {
                return factory;
            }
        }

        public IPaint PaintController
        {
            get
            {
                return paintController;
            }
        }


    }
}
