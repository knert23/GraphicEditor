using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicEditor
{
    interface IPaint
    {
        void SetPort(IntPtr handle);

        void Refresh();

        void RefreshMarkers();

        void DrawMarker(int x, int y);

        void Clear();
    }
}
