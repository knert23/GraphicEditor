using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class SelectDealer : ISelectDealer
    {
        SelectionStore selectionStore;
        ObjectsStrore objectsStore;
        Painter painter;
        public SelectDealer(Painter painter, SelectionStore selectionStore, ObjectsStrore objectsStore)
        {
            this.selectionStore = selectionStore;
            this.objectsStore = objectsStore;
            this.painter = painter;
        }
        public bool TrySelect(int x, int y)
        {
            selectionStore.Clear();
            GraphicObject graphicObject = objectsStore.GetObjectAtPoint(x, y);
            if (graphicObject != null)
            {
                selectionStore.Add(CreateSelection(graphicObject));
                return true;
            }

            return false;
        }

        private Selection CreateSelection(GraphicObject graphicObject)
        {
            // Это всё временно
            if (graphicObject is Line)
            {
                return new LineSelection(painter, graphicObject as Line);
            }
            if (graphicObject is Rectangle)
            {
                return new RectangleSelection(painter, graphicObject as Rectangle);
            }
            return null;
        }

        public bool TryGrab(int x, int y)
        {
            // освобождение selection
            selectionStore.Release();
            for (int i = 0; i < selectionStore.Count; i++)
            {
                if (selectionStore[i].TryGrab(x, y)) return true;

            }
            return false;
        }

        public bool TryDrag(int x, int y)
        {
            for(int i = 0; i < selectionStore.Count; i++)
            {
                if (selectionStore[i].TryDrag(x, y)) return true;
            }

            return false;
        }

        public bool TryRelease(int x, int y)
        {
            for(int i = 0; i < selectionStore.Count; i++)
            {
                if (selectionStore[i].Release()) return true;
            }

            return false;
        }
    }
}
