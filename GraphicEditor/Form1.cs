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

        Painter painter = new Painter();
        private void Form1_Load(object sender, EventArgs e)
        {
            painter.SetPort(Handle);
            painter.Clear();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Frame frame = new Frame(100, 100, 400, 100);
            PropertiesList props = new PropertiesList();
            props.Add(new LineSetOfProperties(Color.Red, 10));
            Line line = new Line(frame, props);
            line.Draw(painter);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frame frame = new Frame(400, 400, 500, 500);
            PropertiesList props = new PropertiesList();
            props.Add(new LineSetOfProperties(Color.Black, 5));
            props.Add(new FillSetOfProperties(Color.Beige));
            Rectangle rectangle = new Rectangle(frame, props);
            rectangle.Draw(painter);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frame frame = new Frame(200, 200, 500, 400);
            PropertiesList props = new PropertiesList();
            props.Add(new LineSetOfProperties(Color.Black, 5));
            props.Add(new FillSetOfProperties(Color.DarkOrange));
            Ellips ellips = new Ellips(frame, props);
            ellips.Draw(painter);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Rectangle
            Frame frame2 = new Frame(500, 100, 550, 150);
            // Ellipse
            Frame frame3 = new Frame(550, 150, 580, 180);

            PropertiesList props = new PropertiesList();
            props.Add(new LineSetOfProperties(Color.Black, 5));
            props.Add(new FillSetOfProperties(Color.Green));

            Rectangle rectangle = new Rectangle(frame2, props);
            Ellips ellips = new Ellips(frame3, props);

            List<GraphicObject> list = new List<GraphicObject>();
            list.Add(rectangle);
            list.Add(ellips);
            Group group = new Group(list);
            group.Draw(painter);
        }
    }
}
