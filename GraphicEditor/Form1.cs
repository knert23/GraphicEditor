using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Controller controller = new Controller(new Model());

        private void Form1_Load(object sender, EventArgs e)
        {
            controller.PaintController.SetPort(Handle);
            controller.PaintController.Clear();
        }

        private void ButtonLine_Click(object sender, EventArgs e)
        {
            controller.Action.ObjectType = ObjectType.Line;
        }

        private void ButtonRectangle_Click(object sender, EventArgs e)
        {
            controller.Action.ObjectType = ObjectType.Rectangle;
        }

        private void ButtonEllipse_Click(object sender, EventArgs e)
        {
            controller.Action.ObjectType = ObjectType.Ellipse;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            controller.Action.MouseUp(e.X, e.Y);
            controller.PaintController.Refresh();
        }
    }
}
