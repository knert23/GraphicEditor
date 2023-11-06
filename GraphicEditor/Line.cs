﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class Line: Figure
    {
        public Line(Frame frame, PropertiesList propertiesList) : base(frame, propertiesList) { }
        public override void DrawGeometry(Painter painter)
        {
            painter.Line(Frame.X1, Frame.Y1, Frame.X2, Frame.Y2);
        }
    }
}
