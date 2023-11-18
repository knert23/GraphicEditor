using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicEditor
{
    abstract class SetOfProps
    {
        public abstract void Apply(Painter painter);
    }

    class PropertiesList : List<SetOfProps>
    {
        public void Apply(Painter painter)
        {
            for (int i = 0; i < this.Count; i++)
            {
                this[i].Apply(painter);
            }
        }
    }

    class LineSetOfProperties : SetOfProps
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

    class FillSetOfProperties : SetOfProps
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
