using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    interface IAction
    {
        ObjectType ObjectType { get; set; }

        void MouseUp(int x, int y);
    }
}
