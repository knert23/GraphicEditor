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

        public bool isLineColorChanged { get; set; } = false;
        public bool isLineWidthChanged { get; set; } = false;
        public bool isFillColorChanged { get; set; } = false;

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
                    fillSetOfProperties.BrushColor = Color.White;
                    props.Add(fillSetOfProperties.Clone());
                    Rectangle rectangle = new Rectangle(frame, props);
                    objectsStore.Add(rectangle);
                    break;
                case ObjectType.Ellipse:
                    frame = new Frame(x, y, x, y);
                    props = new PropertiesList();
                    props.Add(lineSetOfProperties.Clone());
                    fillSetOfProperties.BrushColor = Color.White;
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

        // Изменение стилей объектов
        public void RefreshObjectsStyle(List<GraphicObject> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < objectsStore.Count; j++)
                {
                    // Сравнение просто по объектам не работает почему-то, поэтому так
                    if (objectsStore[j].Frame.Equals(list[i].Frame))
                    {
                        objectsStore[j] = GetObjectByType(objectsStore[j]);
                        objectsStore[j].isStyleChanged = true;
                        break;
                    }
                }
            }

            isLineColorChanged = false;
            isLineWidthChanged = false;
            isFillColorChanged = false;
        }

        private PropertiesList GetProperties(GraphicObject graphicObject)
        {
            PropertiesList props = new PropertiesList();
            if (isLineColorChanged)
            {
                LineSetOfProperties newLineProps = new LineSetOfProperties(lineSetOfProperties.LineColor, (graphicObject as Figure).LineProps.LineWidth);

                if (isLineWidthChanged)
                {
                    newLineProps.LineWidth = lineSetOfProperties.LineWidth;
                }

                props.Add(newLineProps);
            }
            else if (isLineWidthChanged)
            {
                LineSetOfProperties newLineProps = new LineSetOfProperties((graphicObject as Figure).LineProps.LineColor, lineSetOfProperties.LineWidth);
                props.Add(newLineProps);
            }
            else
            {
                LineSetOfProperties newLineProps = new LineSetOfProperties((graphicObject as Figure).LineProps.LineColor, (graphicObject as Figure).LineProps.LineWidth);
                props.Add(newLineProps);
            }

            if (isFillColorChanged && !(graphicObject is Line))
            {
                FillSetOfProperties newFillProps = new FillSetOfProperties(fillSetOfProperties.BrushColor);
                props.Add(newFillProps);
            }
            else if (!(graphicObject is Line))
            {
                FillSetOfProperties newFillProps = new FillSetOfProperties((graphicObject as Figure).FillProps.BrushColor);
                props.Add(newFillProps);
            }

            return props;
        }

        private void RefreshGroupObjectsStyle(List<GraphicObject> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = GetObjectByType(list[i]);
            }
        }

        private GraphicObject GetObjectByType(GraphicObject graphicObject)
        {
            PropertiesList props;
            switch (graphicObject.GetObjectType())
            {
                case ObjectType.Line:
                    props = GetProperties(graphicObject);
                    return new Line(graphicObject.Frame, props);
                case ObjectType.Rectangle:
                    props = GetProperties(graphicObject);
                    return new Rectangle(graphicObject.Frame, props);
                case ObjectType.Ellipse:
                    props = GetProperties(graphicObject);
                    return new Ellipse(graphicObject.Frame, props);
                case ObjectType.Group:
                    RefreshGroupObjectsStyle((graphicObject as Group).GroupObjects);
                    return new Group((graphicObject as Group).GroupObjects);
                default:
                    return null;
            }
        }
    }
}
