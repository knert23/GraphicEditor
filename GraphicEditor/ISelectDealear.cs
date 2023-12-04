using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    interface ISelectDealer
    {
        bool TrySelect(int x, int y);
        bool TryGrab(int x, int y);
        bool TryDrag(int x, int y);
        bool TryRelease(int x, int y);
    }
}
