using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class PropertiesList: List<SetOfProps>
    {
        public void Apply(Painter painter)
        {
            for (int i = 0; i < this.Count; i++)
            {
                this[i].Apply(painter);
            }
        }
    }
}
