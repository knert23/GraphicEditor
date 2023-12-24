using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class Scene
    {
        Painter painter;
        ObjectsStrore objectsStrore;
        SelectionStore selectionStore;

        public Scene(ObjectsStrore objectsStrore,  Painter painter, SelectionStore selectionStore)
        {
            this.painter = painter;
            this.objectsStrore = objectsStrore;
            this.selectionStore = selectionStore;
        }

        public void Refresh()
        {
            // Очиста перед очередной отрисовкой, если убрать - будет ужас
            painter.Clear();

            // Отрисовка объектов
            for (int i = 0; i < objectsStrore.Count; i++)
            {
                objectsStrore[i].Draw(painter);
            }
        }

        public void RefreshMarkers()
        {
            // Отрисовка выделений (маркеров)
            for (int i = 0; i < selectionStore.Count; i++)
            {
                selectionStore[i].Draw(painter);
            }
        }
    }
}
