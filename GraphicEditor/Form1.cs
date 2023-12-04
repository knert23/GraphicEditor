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
            controller.Settings.ObjectType = ObjectType.Line;
            controller.Settings.SetObjectType();

            controller.Settings.ObjectStyleSettings.PenSettings.LineColor = Color.Red;
            controller.Settings.ObjectStyleSettings.PenSettings.LineWidth = 10;
            controller.Settings.SetObjectStyleSettings();
        }

        private void ButtonRectangle_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectType = ObjectType.Rectangle;
            controller.Settings.SetObjectType();

            controller.Settings.ObjectStyleSettings.PenSettings.LineColor = Color.DeepSkyBlue;
            controller.Settings.ObjectStyleSettings.PenSettings.LineWidth = 3;
            controller.Settings.ObjectStyleSettings.BrushSettings.BrushColor = Color.GreenYellow;
            controller.Settings.SetObjectStyleSettings();
        }

        private void ButtonEllipse_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectType = ObjectType.Ellipse;
            controller.Settings.SetObjectType();
        }

        // Для того, что бы событие MouseMove срабатывало только после MouseDown
        bool isDown = false;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            controller.Action.MouseDown(e.X, e.Y);
            //controller.PaintController.Refresh();
            isDown = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            controller.Action.MouseUp(e.X, e.Y);
            controller.PaintController.Refresh();
            isDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                controller.Action.MouseMove(e.X, e.Y);
            }
        }
    }
}