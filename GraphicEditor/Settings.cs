using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class Settings : ISettings
    {
        IModel Model { get; set; }
        IObjectStyleSettings objectStyleSettings;
        public Settings(IModel model, IObjectStyleSettings objectStyleSettings)
        {
            Model = model;
            this.objectStyleSettings = objectStyleSettings;
        }

        public IObjectStyleSettings ObjectStyleSettings { get => objectStyleSettings; }


        public void SetObjectStyleSettings()
        {
            Model.FactorySettings.PenSettings.LineColor = objectStyleSettings.PenSettings.LineColor;
            Model.FactorySettings.isLineColorChanged = objectStyleSettings.isLineColorChanged;

            Model.FactorySettings.PenSettings.LineWidth = objectStyleSettings.PenSettings.LineWidth;
            Model.FactorySettings.isLineWidthChanged = objectStyleSettings.isLineWidthChanged;

            Model.FactorySettings.BrushSettings.BrushColor = objectStyleSettings.BrushSettings.BrushColor;
            Model.FactorySettings.isFillColorChanged = objectStyleSettings.isFillColorChanged;

            /*Color oldLineColor = Model.FactorySettings.PenSettings.LineColor;
            Color newLinecolor = objectStyleSettings.PenSettings.LineColor;
            if (oldLineColor != newLinecolor)
            {
                Model.FactorySettings.PenSettings.LineColor = newLinecolor;
                Model.FactorySettings.isLineColorChanged = true;
            }

            float oldLineWidth = Model.FactorySettings.PenSettings.LineWidth;
            float newLineWidth = objectStyleSettings.PenSettings.LineWidth;
            if (oldLineWidth != newLineWidth)
            {
                Model.FactorySettings.PenSettings.LineWidth = newLineWidth;
                Model.FactorySettings.isLineWidthChanged = true;
            }

            Color oldFillColor = Model.FactorySettings.BrushSettings.BrushColor;
            Color newFillColor = objectStyleSettings.BrushSettings.BrushColor;
            if (oldFillColor != newFillColor)
            {
                Model.FactorySettings.BrushSettings.BrushColor = newFillColor;
                Model.FactorySettings.isFillColorChanged = true;
            }*/
        }

        public void Refresh()
        {
            // Реализацию конечно можно было и лучше сделать, а не вот это вот
            Model.SelectDealer.RefreshSelections();
            Model.PaintController.Refresh();
            Model.PaintController.RefreshMarkers();
        }
    }
}
