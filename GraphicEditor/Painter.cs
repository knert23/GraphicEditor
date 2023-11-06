using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicEditor
{
    class Painter
    {
        Graphics graphics;
        Pen pen;
        SolidBrush solidBrush;

        public Painter()
        {
            // Создание пера
            pen = new Pen(Color.Black);
            // Создание кисти
            solidBrush = new SolidBrush(Color.White);
        }

        // Настройка холста
        public void SetPort(IntPtr handle)
        {
            graphics = Graphics.FromHwnd(handle);
        }

        public void Clear()
        {
            graphics.Clear(Color.White);
        }

        public void Line(int x1, int y1, int x2, int y2)
        {
            graphics.DrawLine(pen, x1, y1, x2, y2);
        }
        public void Rectangle(int x, int y, int width, int height)
        {
            graphics.DrawRectangle(pen, x, y, width, height);
            graphics.FillRectangle(solidBrush, x, y, width, height);
        }
        public void Ellips(int x, int y, int width, int height)
        {
            graphics.DrawEllipse(pen, x, y, width, height);
            graphics.FillEllipse(solidBrush, x, y, width, height);
        }

        public Color LineColor
        {
            set
            {
                pen.Color = value;
            }
        }

        public float LineWidht
        {
            set
            {
                pen.Width = value;
            }
        }
        public Color FillColor
        {
            set
            {
                solidBrush.Color = value;
            }
        }

    }
}
