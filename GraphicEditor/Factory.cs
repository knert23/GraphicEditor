using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicEditor
{
    class Factory : ICreator, IObjectStyleSettings
    {
        ObjectsStrore objectsStore;
        LineSetOfProperties lineSetOfProperties;
        FillSetOfProperties fillSetOfProperties;
        public Factory(ObjectsStrore objectsStore)
        {
            this.objectsStore = objectsStore;
            lineSetOfProperties = new LineSetOfProperties(Color.Black, 1);
            fillSetOfProperties = new FillSetOfProperties(Color.White);
        }

        public ObjectType ObjectType { get; set; }

        public IPenSettings PenSettings { get => lineSetOfProperties; }
        public IBrushSettings BrushSettings { get => fillSetOfProperties; }

        public void CreateObject(int x, int y)
        {
            switch (ObjectType)
            {
                case ObjectType.Line:
                    Frame frame = new Frame(x, y, x, y);
                    PropertiesList props = new PropertiesList();
                    props.Add(lineSetOfProperties.Clone());
                    Line line = new Line(frame, props);
                    objectsStore.Add(line);
                    break;
                case ObjectType.Rectangle:
                    frame = new Frame(x, y, x, y);
                    props = new PropertiesList();
                    props.Add(lineSetOfProperties.Clone());
                    props.Add(fillSetOfProperties.Clone());
                    Rectangle rectangle = new Rectangle(frame, props);
                    objectsStore.Add(rectangle);
                    break;
                case ObjectType.Ellipse:
                    frame = new Frame(x, y, x, y);
                    props = new PropertiesList();
                    props.Add(lineSetOfProperties.Clone());
                    props.Add(fillSetOfProperties.Clone());
                    Ellipse ellipse = new Ellipse(frame, props);
                    objectsStore.Add(ellipse);
                    break;
            }  
        }
        
        public void CreateGroup(List<GraphicObject> list)
        {
            // Удаление группируемых объектов
            objectsStore.DeleteObjects(list);
            // Создание группы
            Group group = new Group(list);
            // Добавлени группы в список
            objectsStore.Add(group);
        }
    }
}
