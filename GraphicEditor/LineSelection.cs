using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class LineSelection : Selection
    {
        Line Line { get; set; }
        public LineSelection(Line line) : base(line)
        {
            Line = line;
            CreateMarkers();
        }

        protected override void CreateMarkers()
        {
            Frame frame = Line.Frame;

            Marker marker = new Marker(frame.X1, frame.Y1, 1);
            markers.Add(marker);

            Marker marker2 = new Marker(frame.X2, frame.Y2, 2);
            markers.Add(marker2);
        }

        protected override bool RefreshMarkerCoordinates()
        {
            for (int i = 0; i < markers.Count; i++)
            {
                switch (markers[i].MarkerNumber)
                {
                    case 1:
                        markers[i].X = Line.Frame.X1;
                        markers[i].Y = Line.Frame.Y1;
                        break;
                    case 2:
                        markers[i].X = Line.Frame.X2;
                        markers[i].Y = Line.Frame.Y2;
                        break;
                    default:
                        return false;
                }
            }

            return true;
        }

        // Непонятно зачем, ведь проверка всегда по коллекции маркеров и неважно, какой объект
        /*public override void Draw(Painter painter)
        {
            for (int i = 0; i < markers.Count; i++)
            {
                markers[i].Draw(painter);
            } 
        }*/

        // Непонятно зачем, ведь проверка всегда по коллекции маркеров и неважно, какой объект
        /*public override bool TryGrab(int x, int y)
        {
            for (int i = 0; i < markers.Count; i++)
            {
                if 
            }

            return false;
        }*/
    }
}
