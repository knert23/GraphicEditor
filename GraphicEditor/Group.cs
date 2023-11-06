using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class Group:GraphicObject
    {
        List<GraphicObject> listOfGraphicObject = new List<GraphicObject>();
        public Group(List<GraphicObject> listOfGraphicObject): base(SetFrame(listOfGraphicObject))
        {
            for (int i = 0; i < listOfGraphicObject.Count; i++)
            {
                this.listOfGraphicObject.Add(listOfGraphicObject[i]);
            }
        }

        public override void Draw(Painter painter)
        {
            for (int i = 0; i < listOfGraphicObject.Count; i++)
            {
                listOfGraphicObject[i].Draw(painter);
            }
        }

        static Frame SetFrame(List<GraphicObject> listOfGraphicObject)
        {
            Frame frame = new Frame(0, 0, 0, 0);

            for (int i = 0; i < listOfGraphicObject.Count; i++)
            {
                frame += listOfGraphicObject[i].Frame;
            }

            return frame;
        }
    }
}
