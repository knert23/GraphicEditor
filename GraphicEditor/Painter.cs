using System;
using System.Drawing;

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
            graphics.DrawRectangle(pen, x, y, Math.Abs(width), Math.Abs(height));
            graphics.FillRectangle(solidBrush, x + pen.Width, y + pen.Width, width - pen.Width, height - pen.Width);
        }
        public void Ellipse(int x, int y, int width, int height)
        {
            graphics.DrawEllipse(pen, x, y, Math.Abs(width), Math.Abs(height));
            graphics.FillEllipse(solidBrush, x + pen.Width, y + pen.Width, width - pen.Width, height - pen.Width);
        }
        public void DrawMarker(int x, int y)
        {
            Pen penMarker = new Pen(Color.Black, 1);
            graphics.DrawRectangle(penMarker, x, y, 5, 5);
            SolidBrush solidBrushMarker = new SolidBrush(Color.White);
            graphics.FillRectangle(solidBrush, x + penMarker.Width, y + penMarker.Width, 3 - penMarker.Width, 3 - penMarker.Width);
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
