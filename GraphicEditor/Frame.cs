using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class Frame
    {
        // Задание границ фигуры
        public Frame(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public static Frame operator +(Frame frame1, Frame frame2)
        {
            int x1, y1, x2, y2;

            x1 = frame1.X1 >= frame2.X1 ? frame2.X1 : frame1.X1;
            y1 = frame1.Y1 >= frame2.Y1 ? frame2.Y1 : frame1.Y1;
            x2 = frame1.X2 >= frame2.X2 ? frame1.X2 : frame2.X2;
            y2 = frame1.Y2 >= frame2.Y2 ? frame1.Y2 : frame2.Y2;

            return new Frame(x1, y1, x2, y2);
        } 

        // Координаты границы фигуры
        int x1, y1, x2, y2;

        public int X1 { get => x1; }

        public int Y1 { get => y1; }

        public int X2 { get => x2; }

        public int Y2 { get => y2; }

        public bool ChangeFrame(int markerX, int markerY, int moveX, int moveY)
        {   
            // Определение кординаты маркера, для того чтобы понять, где нужно производить смещение
            string location = LocateCoordinate(markerX, markerY);
            switch (location)
            {
                case "upperLeft":
                    if (moveX >= X2 && moveY >= Y2) goto case "lowerRight";
                    if (moveX >= X2 && moveY <= Y1) goto case "upperRight";
                    if (moveX <= X1 && moveY >= Y2) goto case "lowerLeft";
                    x1 = moveX;
                    y1 = moveY;
                    return true;
                case "lowerLeft":
                    if (moveX >= X2 && moveY <= Y1) goto case "upperRight";
                    if (moveX >= X2 && moveY >= Y2) goto case "lowerRight";
                    if (moveX <= X1 && moveY <= Y1) goto case "upperLeft";
                    x1 = moveX;
                    y2 = moveY;
                    return true;
                case "lowerRight":
                    x2 = moveX;
                    y2 = moveY;
                    return true;
                case "upperRight":
                    x2 = moveX;
                    y1 = moveY;
                    return true;
                case "undefined":
                    return false;
            }

            return false;
        }

        public string LocateCoordinate(int x, int y)
        {
            if (x <= X1 && x >= X1 - 5 && y >= Y1 - 5 && y <= Y1) return "upperLeft";

            if (x <= X1 && x >= X1 -5 && y >= Y2 && y <= Y2 + 5) return "lowerLeft";

            if (x <= X2 + 5 && x >= X2 && y >= Y2 && y <= Y2 + 5) return "lowerRight";

            if (x <= X2 + 5 && x >= X2 && y >= Y1 - 5 && y <= Y1) return "upperRight";

            return "undefined";
        }
    }
}
