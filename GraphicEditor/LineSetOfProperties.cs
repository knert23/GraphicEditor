using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicEditor
{
    class LineSetOfProperties: SetOfProps
    {
        public LineSetOfProperties(Color color, float width)
        {
            Color = color;
            Width = width;
        }

        Color Color { get; set; }
        float Width { get; set; }

        public override void Apply(Painter painter)
        {
            painter.LineColor = Color;
            painter.LineWidht = Width;
        }
    }
}
