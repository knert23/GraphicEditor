using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class Marker
    {
        public Marker(int x, int y, string location)
        {
            X = x;
            Y = y;
            this.location = location;
        }

        // Где находится маркер (например, левый верхний)
        string location;
        public string Location { get => location; }

        // Координаты края одной из фигуры
        public int X { get; set; }
        public int Y { get; set; }
        public void Draw(Painter painter)
        {
            // Здесь отрисовка маркера
            painter.DrawMarker(X, Y);
        }

        public bool TryGrab(int x, int y)
        {
            if (x >= X && x <= X + 5 && y >= Y && y <= Y + 5) return true;

            return false;
        }
    }
}
