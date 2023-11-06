using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    abstract class Figure: GraphicObject
    {
        PropertiesList propertiesList;
        public Figure(Frame frame, PropertiesList propertiesList):base(frame)
        {
            this.propertiesList = propertiesList;
        }

        public override void Draw (Painter painter)
        {
            propertiesList.Apply(painter);
            DrawGeometry(painter);
        }
        public abstract void DrawGeometry(Painter painter);
    }
}
