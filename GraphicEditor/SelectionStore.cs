using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class SelectionStore: List<Selection>
    {
        public void Release()
        {
            for (int i = 0; i < this.Count; i++)
            {
                this[i].Release();
            }
        }
    }
}
