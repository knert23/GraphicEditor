using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class Rectangle: Figure
    {
        public Rectangle(Frame frame, PropertiesList propertiesList) : base(frame, propertiesList) { }
        public override void DrawGeometry(Painter painter)
        {
            painter.Rectangle(Frame.X1, Frame.Y1, Frame.X2 - Frame.X1, Frame.Y2 - Frame.Y1);
        }
    }
}
