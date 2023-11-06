using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class Ellips: Figure
    {
        public Ellips(Frame frame, PropertiesList propertiesList) : base(frame, propertiesList) { }
        public override void DrawGeometry(Painter painter)
        {
            painter.Ellips(Frame.X1, Frame.Y1, Frame.X2 - Frame.X1, Frame.Y2 - Frame.Y1);
        }
    }
}
