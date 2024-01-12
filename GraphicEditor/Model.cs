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
        SelectionStore selectionStore;
        SelectDealer selectDealear;
        public Model()
        {
            objectsStore = new ObjectsStrore();
            painter = new Painter();
            factory = new Factory(objectsStore);
            selectionStore = new SelectionStore();
            scene = new Scene(objectsStore, painter, selectionStore);
            paintController = new PaintController(scene, painter);
            selectDealear = new SelectDealer(selectionStore, objectsStore, factory);
        }
        public ICreator Creator { get => factory; }

        public IPaint PaintController { get => paintController; }

        public ISelectDealer SelectDealer { get => selectDealear; }

        public IObjectStyleSettings FactorySettings { get => factory; }

        public int SelectionStoreCount { get => selectionStore.Count; }
    }
}
