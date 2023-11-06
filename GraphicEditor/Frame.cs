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

            x1 = frame1.X1 > frame2.X1 ? frame1.x1 : frame2.x1;
            y1 = frame1.Y1 > frame2.Y1 ? frame1.Y1 : frame2.Y1;
            x2 = frame1.X2 > frame2.X2 ? frame1.X2 : frame2.X2;
            y2 = frame1.Y2 > frame2.Y2 ? frame1.Y2 : frame2.Y2;

            return new Frame(x1, y1, x2, y2);
        } 

        // Координаты границы фигуры
        int x1, y1, x2, y2;

        public int X1
        {
            get
            {
                return x1;
            }
        }

        public int Y1
        {
            get
            {
                return y1;
            }
        }

        public int X2
        {
            get
            {
                return x2;
            }
        }

        public int Y2
        {
            get
            {
                return y2;
            }
        }
    }
}
