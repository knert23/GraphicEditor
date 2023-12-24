using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{

    public enum ObjectType
    {
        Line,
        Rectangle,
        Ellipse,
        Group
    }

    interface ICreator
    {
        void RefreshObjectsStyle(List<GraphicObject> list);
        ObjectType ObjectType { get; set; }

        void CreateObject(int x, int y);
    }
}
