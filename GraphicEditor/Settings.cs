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
        public int SelectionStoreCount { get => Model.SelectionStoreCount; }
        public Settings(IModel model, IObjectStyleSettings objectStyleSettings)
        {
            Model = model;
            this.objectStyleSettings = objectStyleSettings;
        }

        public IObjectStyleSettings ObjectStyleSettings { get => objectStyleSettings; }


        public void SetObjectStyleSettings()
        {
            Model.FactorySettings.PenSettings.LineColor = objectStyleSettings.PenSettings.LineColor;

            Model.FactorySettings.PenSettings.LineWidth = objectStyleSettings.PenSettings.LineWidth;

            Model.FactorySettings.BrushSettings.BrushColor = objectStyleSettings.BrushSettings.BrushColor;
        }

        public void Refresh(StyleType styleType)
        {
            // Реализацию конечно можно было и лучше сделать, а не вот это вот
            // Сделать с модели канал для доступа к смене настроек стиля объекта, как у фабрики
            Model.SelectDealer.RefreshSelections(ObjectStyleSettings, styleType);
            Model.PaintController.Refresh();
            Model.PaintController.RefreshMarkers();
        }
    }
}
