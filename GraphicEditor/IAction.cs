using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    interface IAction
    {

        // Начальное создание объека, пользователь может растянуть объект
        void MouseDown(int x, int y);

        // Окончательное создание объекта
        void MouseUp(int x, int y);

        // Перемещение объекта
        void MouseMove(int x, int y);

        // Начальное создание объекта
        void StartCreate(ObjectType objectType);

        // Выход
        void Esc();

        // Удаление
        void Del();

        // Выделение фигур 
        void ShiftMouseUp(int x, int y);

        // Группировка объектов
        void Group();

        // Разгруппировка объектов
        void Ungroup();
    }
}
