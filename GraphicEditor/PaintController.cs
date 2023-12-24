using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicEditor
{
    class PaintController: IPaint
    {
        Painter painter;
        Scene scene;

        public PaintController(Scene scene, Painter painter)
        {
            this.scene = scene;
            this.painter = painter;
        }

        public void SetPort(IntPtr handle)
        {
            painter.SetPort(handle);
        }

        public void Refresh()
        {
            scene.Refresh();
        }

        public void RefreshMarkers()
        {
            scene.RefreshMarkers();
        }

        public void DrawMarker(int x, int y)
        {
            painter.DrawMarker(x, y);
        }

        public void Clear()
        {
            painter.Clear();
        }
    }
}
