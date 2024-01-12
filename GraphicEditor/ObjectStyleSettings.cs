using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicEditor
{
    class ObjectStyleSettings : IObjectStyleSettings
    {
        LineSetOfProperties lineSetOfProperties;
        FillSetOfProperties FillSetOfProperties;
        public ObjectStyleSettings()
        {
            lineSetOfProperties = new LineSetOfProperties(Color.Black, 1);
            FillSetOfProperties = new FillSetOfProperties(Color.White);
        }
        public IPenSettings PenSettings { get => lineSetOfProperties; }

        public IBrushSettings BrushSettings { get => FillSetOfProperties; }
    }
}
