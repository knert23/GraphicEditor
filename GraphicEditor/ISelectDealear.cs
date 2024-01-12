using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    interface ISelectDealer
    {
        SelectionStore SelectionStore { get; }
        bool TrySelect(int x, int y);
        bool TryGrab(int x, int y);
        bool TryDrag(int x, int y);
        bool TryReplace(int x, int y);
        bool TryRelease();
        bool TryAddSelection(int x, int y);
        void DeleteSelected();
        void SkipSelection(List<GraphicObject> list);
        void Group();
        void Ungroup();
        void RefreshSelections(IObjectStyleSettings objectStyleSettings, StyleType styleType);
    }
}
