using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    interface ISettings
    {
        IObjectStyleSettings ObjectStyleSettings { get; }

        int SelectionStoreCount { get; }

        void SetObjectStyleSettings();

        void Refresh(StyleType styleType);
    }

    public enum StyleType
    {
        LineColor,
        LineWidth,
        FillColor
    }
}
