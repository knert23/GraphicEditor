using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class Scene
    {
        Painter painter;
        ObjectsStrore objectsStrore;

        public Scene(ObjectsStrore objectsStrore,  Painter painter)
        {
            this.painter = painter;
            this.objectsStrore = objectsStrore;
        }

        public void Refresh()
        {
            for (int i = 0; i < objectsStrore.Count; i++)
            {
                objectsStrore[i].Draw(painter);
            }   
        }
    }
}
