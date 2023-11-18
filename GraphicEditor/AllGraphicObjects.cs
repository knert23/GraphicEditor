using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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

    abstract class Figure : GraphicObject
    {
        PropertiesList propertiesList;
        public Figure(Frame frame, PropertiesList propertiesList) : base(frame)
        {
            this.propertiesList = propertiesList;
        }

        public override void Draw(Painter painter)
        {
            propertiesList.Apply(painter);
            DrawGeometry(painter);
        }
        public abstract void DrawGeometry(Painter painter);
    }

    class Group : GraphicObject
    {
        List<GraphicObject> listOfGraphicObject = new List<GraphicObject>();
        public Group(List<GraphicObject> listOfGraphicObject) : base(SetFrame(listOfGraphicObject))
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

    class Line : Figure
    {
        public Line(Frame frame, PropertiesList propertiesList) : base(frame, propertiesList) { }
        public override void DrawGeometry(Painter painter)
        {
            painter.Line(Frame.X1, Frame.Y1, Frame.X2, Frame.Y2);
        }
    }

    class Ellipse : Figure
    {
        public Ellipse(Frame frame, PropertiesList propertiesList) : base(frame, propertiesList) { }
        public override void DrawGeometry(Painter painter)
        {
            painter.Ellipse(Frame.X1, Frame.Y1, Frame.X2 - Frame.X1, Frame.Y2 - Frame.Y1);
        }
    }

    class Rectangle : Figure
    {
        public Rectangle(Frame frame, PropertiesList propertiesList) : base(frame, propertiesList) { }
        public override void DrawGeometry(Painter painter)
        {
            painter.Rectangle(Frame.X1, Frame.Y1, Frame.X2 - Frame.X1, Frame.Y2 - Frame.Y1);
        }
    }
}
