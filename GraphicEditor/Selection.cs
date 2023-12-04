using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    abstract class Selection
    {
        GraphicObject graphicObject;
        GrabState grabState;
        protected List<Marker> markers;
        Marker activeMarker;

        // Создание маркеров
        protected abstract void CreateMarkers();
        public Selection(GraphicObject graphicObject)
        {
            this.graphicObject = graphicObject;
            markers = new List<Marker>();
        }

        // Здесь метод работает для всего
        // Отрисовка маркеров
        public void Draw(Painter painter)
        {
            for (int i = 0; i < markers.Count; i++)
            {
                markers[i].Draw(painter);
            }
        }

        // Переопределение координат маркеров
        protected abstract bool RefreshMarkerCoordinates();

        // Здесь метод для всего
        public bool TryGrab(int x, int y)
        {   
           for (int i = 0; i < markers.Count; i++)
            {
                if (markers[i].TryGrab(x, y))
                {
                    grabState = GrabState.Marker;
                    activeMarker = markers[i];
                    return true;
                }
            }

            return false;
        }

        public bool TryDrag(int x, int y)
        {
            TryGrab(x, y);
            return graphicObject.Frame.ChangeFrame(activeMarker.X, activeMarker.Y, x, y)
                && RefreshMarkerCoordinates();
        }

        public bool Release()
        {
            if (grabState != GrabState.NotGrabed)
            {
                grabState = GrabState.NotGrabed;
                return true;
            }

            return false;
        }
    }
    enum GrabState{
        NotGrabed,
        Marker,
        Body
    }
}
