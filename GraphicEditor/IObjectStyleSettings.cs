using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    interface IObjectStyleSettings
    {

        bool isLineColorChanged { get; set; }
        bool isLineWidthChanged { get; set; }
        bool isFillColorChanged { get; set; }
        IPenSettings PenSettings { get; }

        IBrushSettings BrushSettings { get; }
    }
}
