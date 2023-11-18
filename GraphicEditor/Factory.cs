using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicEditor
{
    class Factory: ICreator
    {
        ObjectsStrore objectsStore;

        public Factory(ObjectsStrore objectsStore)
        {
            this.objectsStore = objectsStore;
        }

        public ObjectType ObjectType { get; set; }

        public void CreateObject(int x, int y)
        {
            switch (ObjectType)
            {
                case ObjectType.Line:
                    Frame frame = new Frame(x, y, x + 50, y + 50);
                    PropertiesList props = new PropertiesList();
                    props.Add(new LineSetOfProperties(Color.DarkCyan, 5));
                    Line line = new Line(frame, props);
                    objectsStore.Add(line);
                    break;
                case ObjectType.Rectangle:
                    frame = new Frame(x, y, x + 100, y + 100);
                    props = new PropertiesList();
                    props.Add(new LineSetOfProperties(Color.DeepPink, 3));
                    props.Add(new FillSetOfProperties(Color.Olive));
                    Rectangle rectangle = new Rectangle(frame, props);
                    objectsStore.Add(rectangle);
                    break;
                case ObjectType.Ellipse:
                    frame = new Frame(x, y, x + 100, y + 80);
                    props = new PropertiesList();
                    props.Add(new LineSetOfProperties(Color.Chocolate, 3));
                    props.Add(new FillSetOfProperties(Color.Aquamarine));
                    Ellipse ellipse = new Ellipse(frame, props);
                    objectsStore.Add(ellipse);
                    break;
            }
                    
        }
    }
}
