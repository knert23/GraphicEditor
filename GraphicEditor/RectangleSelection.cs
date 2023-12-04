using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class RectangleSelection: Selection
    {
        Rectangle Rectangle { get; set; }
        public RectangleSelection(Painter painter, Rectangle rectangle) : base(rectangle)
        {
            Rectangle = rectangle;
            CreateMarkers();
        }

        protected override void CreateMarkers()
        {
            Frame frame = Rectangle.Frame;
            
            Marker marker = new Marker(frame.X1 - 5, frame.Y1 - 5, "upperLeft");
            markers.Add(marker);

            Marker marker2 = new Marker(frame.X1 - 5, frame.Y2 + 5, "lowerLeft");
            markers.Add(marker2);

            Marker marker3 = new Marker(frame.X2 + 5, frame.Y2 + 5, "lowerRight");
            markers.Add(marker3);

            Marker marker4 = new Marker(frame.X2 + 5, frame.Y1 - 5, "upperRight");
            markers.Add(marker4);

        }

        protected override bool RefreshMarkerCoordinates()
        {
            for (int i = 0; i < markers.Count; i++)
            {
                switch (markers[i].Location)
                {
                    case "upperLeft":
                        markers[i].X = Rectangle.Frame.X1;
                        markers[i].Y = Rectangle.Frame.Y1;
                        break;
                    case "lowerLeft":
                        markers[i].X = Rectangle.Frame.X1;
                        markers[i].Y = Rectangle.Frame.Y2;
                        break;
                    case "lowerRight":
                        markers[i].X = Rectangle.Frame.X2;
                        markers[i].Y = Rectangle.Frame.Y2;
                        break;
                    case "upperRight":
                        markers[i].X = Rectangle.Frame.X2;
                        markers[i].Y = Rectangle.Frame.Y1;
                        break;
                    case "undefined":
                        return false;
                    default:
                        return false;

                }
            }

            return true;
        }
    }
}
