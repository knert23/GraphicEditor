using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicEditor
{
    class FillSetOfProperties: SetOfProps
    {
        public FillSetOfProperties(Color color)
        {
            FillColor = color;
        }

        Color FillColor { get; set; }

        public override void Apply(Painter painter)
        {
            painter.FillColor = FillColor;
        }
    }
}
