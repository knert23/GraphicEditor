using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    abstract class GraphicObject
    {
        Frame frame;
        public GraphicObject(Frame frame)
        {
            this.frame = frame;
        }

        public abstract void Draw(Painter painter);

        public Frame Frame
        {
            get
            {
                return frame;
            }
        }
    }
}
