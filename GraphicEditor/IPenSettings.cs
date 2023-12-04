using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicEditor
{
    interface IPenSettings
    {
        Color LineColor { get; set; }
        
        float LineWidth { get; set; }
    }
}
