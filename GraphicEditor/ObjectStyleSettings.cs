using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicEditor
{
    class ObjectStyleSettings : IObjectStyleSettings
    {
        IModel Model { get; set; }
        public ObjectStyleSettings(IModel model)
        {
            Model = model;
        }
        public IPenSettings PenSettings { get => Model.FactorySettings.PenSettings; }

        public IBrushSettings BrushSettings { get => Model.FactorySettings.BrushSettings; }
        public bool isLineColorChanged { get => Model.FactorySettings.isLineColorChanged; 
            set => Model.FactorySettings.isLineColorChanged = value; }
        public bool isLineWidthChanged { get => Model.FactorySettings.isLineWidthChanged; 
            set => Model.FactorySettings.isLineWidthChanged = value; }
        public bool isFillColorChanged { get => Model.FactorySettings.isFillColorChanged; 
            set => Model.FactorySettings.isFillColorChanged = value; }
    }
}
