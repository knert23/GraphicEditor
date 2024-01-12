using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class SelectDealer : ISelectDealer
    {
        SelectionStore selectionStore;
        ObjectsStrore objectsStore;
        Factory factory;
        public SelectDealer(SelectionStore selectionStore, ObjectsStrore objectsStore, Factory factory)
        {
            this.selectionStore = selectionStore;
            this.objectsStore = objectsStore;
            this.factory = factory;
        }

        public SelectionStore SelectionStore { get => selectionStore; }

        public bool TrySelect(int x, int y)
        {
            selectionStore.Clear();
            GraphicObject graphicObject = objectsStore.GetObjectAtPoint(x, y);
            if (graphicObject != null)
            {
                selectionStore.Add(CreateSelection(graphicObject));
                return true;
            }

            return false;
        }

        private Selection CreateSelection(GraphicObject graphicObject)
        {
            // Это всё временно
            if (graphicObject is Line)
            {
                return new LineSelection(graphicObject as Line);
            }
            if (graphicObject is Rectangle)
            {
                return new RectangleSelection(graphicObject as Rectangle);
            }
            if (graphicObject is Ellipse)
            {
                return new EllipseSelection(graphicObject as Ellipse);
            }
            if (graphicObject is Group)
            {
                return new GroupSelection(graphicObject as Group);
            }
            return null;
        }

        public bool TryGrab(int x, int y)
        {
            // освобождение selection
            selectionStore.Release();
            for (int i = 0; i < selectionStore.Count; i++)
            {
                if (selectionStore[i].TryGrab(x, y)) return true;

            }
            return false;
        }

        public bool TryDrag(int x, int y)
        {
            for(int i = 0; i < selectionStore.Count; i++)
            {
                if (selectionStore[i].TryDrag(x, y)) return true;
            }

            return false;
        }

        public bool TryRelease()
        {
            for(int i = 0; i < selectionStore.Count; i++)
            {
                if (selectionStore[i].Release()) return true;
            }

            return false;
        }

        public bool TryReplace(int x, int y)
        {
            // Проверка, попадает ли курсор в тело какого-либо объекта
            bool inBody = false;
            for (int i = 0; i < selectionStore.Count; i++)
            {
                if (selectionStore[i].GraphicObject.InBody(x, y)) inBody = true; 
            }

            // Если курсор не находится в теле какого-либо объекта
            // то необходимо выйти из метода 
            if (!inBody) return false;

            for (int i = 0; i < selectionStore.Count; i++)
            {
                if (!selectionStore[i].TryReplace(x, y)) return false; 
            }

            return true;
        }

        public bool TryAddSelection(int x, int y)
        {
            GraphicObject graphicObject = objectsStore.GetObjectAtPoint(x, y);
            if (graphicObject == null) return false;
            if (selectionStore.IsSelected(graphicObject)) return false;

            Selection selection = CreateSelection(graphicObject);
            selectionStore.Add(selection);

            return true;
        }

        public void DeleteSelected()
        {
            List<GraphicObject> list = GetListOfSelectedObjects();
            objectsStore.DeleteObjects(list);
            SkipSelection(list);
        }

        public List<GraphicObject> GetListOfSelectedObjects()
        {
            return selectionStore.GetListOfSelectedObjects();
        }

        public void SkipSelection(List<GraphicObject> list)
        {
            selectionStore.DeleteSelections(list);
        }

        public void Group()
        {
            // Получение всех выделенных объектов
            List<GraphicObject> list = GetListOfSelectedObjects();
            // Удаление выделений выделенных объектов
            SkipSelection(list);
            // Создание группы
            factory.CreateGroup(list);
            // либо брать всегда последний объект objectStore, либо сделать так,
            // чтобы  CreateObject возвращал создаваемый объект (параметр, передаваемый в CreateSelection)
            Selection groupSelection = CreateSelection(objectsStore[objectsStore.Count - 1]);
            selectionStore.Add(groupSelection);
        }

        public void Ungroup()
        {
            if (selectionStore.Count > 1) return;
            if (!(selectionStore[0] is GroupSelection)) return;

            // Получение группы
            List<GraphicObject> list = GetListOfSelectedObjects();
            Group group = (Group) list[0];
            // Удаление группы
            objectsStore.DeleteObjects(list);
            // Удаление выделения группы 
            selectionStore.Clear();
            // Добавление объектов из группы в хранилище и создание выделений
            for (int i = 0; i < group.GroupObjects.Count; i++)
            {
                GraphicObject graphicObject = group.GroupObjects[i];
                objectsStore.Add(graphicObject);
                selectionStore.Add(CreateSelection(graphicObject));
            }
        }

        // Обновление выделений после смены стилей объектов
        public void RefreshSelections(IObjectStyleSettings objectStyleSettings, StyleType styleType)
        {
            // Получение всех выделенных объектов
            List<GraphicObject> list = GetListOfSelectedObjects();
            // Удаление выделений выделенных объектов
            SkipSelection(list);
            // Обновление стилей объектов
            RefreshObjectsStyle(list,  objectStyleSettings, styleType);
            // Добавление selection для объектов, у которых обновлен стиль
            for (int i = 0; i < objectsStore.Count; i++)
            {
                if (objectsStore[i].isStyleChanged)
                {
                    selectionStore.Add(CreateSelection(objectsStore[i]));
                    objectsStore[i].isStyleChanged = false;
                }
            }
        }

        // Обновление стилей объекта
        public void RefreshObjectsStyle(List<GraphicObject> list, IObjectStyleSettings objectStyleSettings, StyleType styleType)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < objectsStore.Count; j++)
                {
                    if (objectsStore[j].Frame.Equals(list[i].Frame))
                    {
                        if (objectsStore[j] is Group) RefreshObjectsStyleGroup((objectsStore[j] as Group).GroupObjects, objectStyleSettings, styleType);
                        else
                        {
                            ChangeProperties(objectsStore[j], objectStyleSettings, styleType);
                        }
                        objectsStore[j].isStyleChanged = true;
                        break;
                    }
                }
            }
        }

        // Частный случай для группы
        public void RefreshObjectsStyleGroup(List<GraphicObject> groupObjects, IObjectStyleSettings objectStyleSettings, StyleType styleType)
        {
            for (int i = 0; i < groupObjects.Count; i++)
            {
                if (groupObjects[i] is Group) RefreshObjectsStyleGroup((groupObjects[i] as Group).GroupObjects, objectStyleSettings, styleType);
                else
                {
                    ChangeProperties(groupObjects[i], objectStyleSettings, styleType);
                }
            }
        }

        // Смена стиля фигур, которая производитс по типу меняего стиля
        private void ChangeProperties(GraphicObject graphicObject, IObjectStyleSettings objectStyleSettings, StyleType styleType)
        {
            switch (styleType)
            {
                case StyleType.LineColor:
                    (graphicObject as Figure).LineProps.LineColor = objectStyleSettings.PenSettings.LineColor;
                    break;
                case StyleType.LineWidth:   
                    (graphicObject as Figure).LineProps.LineWidth = objectStyleSettings.PenSettings.LineWidth;
                    break;
                case StyleType.FillColor:
                    if (graphicObject is Line) return;
                    (graphicObject as Figure).FillProps.BrushColor = objectStyleSettings.BrushSettings.BrushColor;
                    break;
            }
        }
    }
}
